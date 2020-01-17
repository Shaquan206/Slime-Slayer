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

    public float attackSpeed;
    public float attackTime;

    private bool attacking;

    private void Start()
    {
        healthSlider.value = health;
    }

    private void Update()
    {
        healthSlider.value = health;
        levelText.text = level.ToString("Level: " + level);
        XPText.text = XP.ToString("XP: " + XP);
        if (XP > level)
        {
            LevelUp();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (attacking == false)
            {
                StartCoroutine(Attack());
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            GameObject redSlime = collision.gameObject;
            Enemy redSlimeScript = redSlime.GetComponent<Enemy>();
            health -= redSlimeScript.damage;
            CheckDead();
        }
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
        XP = 0;
        level++;
        health += 10;
        damage++;
        attackSpeed -= 0.1f;
        if (attackSpeed < 0.1f)
        {
            attackSpeed = 0.1f;
        }
    }
}