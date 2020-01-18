using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider healthSlider;
    public Text levelText;
    public Text XPText;

    public GameObject attack;

    public int level;
    public int XP;

    public int damage;
    public int health;
    public int maxHealth;

    public float regenerateSpeed;

    public float attackSpeed;
    public float attackTime;

    private bool attacking;
    private bool regenerating;

    private bool attacked;

    GameObject enemy;
    Enemy enemyScript;

    private void Start()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
    }

    private void Update()
    {
        healthSlider.value = health;
        levelText.text = level.ToString("Level: " + level);
        XPText.text = XP.ToString("XP: " + XP);
        if (XP > level * level)
        {
            LevelUp();
        }
        if (regenerating == false)
        {
            StartCoroutine(Regenerate());
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (attacking == false)
            {
                StartCoroutine(Attack());
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            if (attacked == false)
            {
                StartCoroutine(BeingAttacked());
                enemy = collision.gameObject;
                enemyScript = enemy.GetComponent<Enemy>();
                health -= enemyScript.damage;
                CheckDead();
            }
        }
    }

    IEnumerator BeingAttacked()
    {
        attacked = true;
        yield return new WaitForSeconds(0.5f);
        attacked = false;
    }

    private void CheckDead()
    {
        if (health < 1)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    IEnumerator Attack()
    {
        attacking = true;
        GameObject attackSprite = Instantiate(attack, transform.position, Quaternion.identity);
        attackSprite.transform.SetParent(transform);
        Destroy(attackSprite.gameObject, attackTime);
        yield return new WaitForSeconds(attackSpeed);
        attacking = false;
    }

    private void LevelUp()
    {
        maxHealth += 10;
        healthSlider.maxValue = maxHealth;
        XP = 0;
        level++;
        health = maxHealth;
        damage++;
        attackSpeed -= 0.1f;
        if (attackSpeed < 0.1f)
        {
            attackSpeed = 0.1f;
        }
    }

    IEnumerator Regenerate()
    {
        regenerating = true;
        yield return new WaitForSeconds(regenerateSpeed);
        if (health < maxHealth)
        {
            health++;
        }
        regenerating = false;
    }
}