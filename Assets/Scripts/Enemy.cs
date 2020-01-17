using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Slider healthSlider;

    private GameObject player;

    public Rigidbody2D rb;

    public float moveSpeed;

    public int health;
    public int damage;
    public int XPAmount;

    private void Start()
    {
        player = GameObject.Find("Player");
        healthSlider.value = health;
    }

    private void Update()
    {
        healthSlider.value = health;
    }

    private void FixedUpdate()
    {
        rb.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Attack(Clone)"))
        {
            Player playerScript = collision.gameObject.GetComponentInParent<Player>();
            health -= playerScript.damage;
            if (health < 1)
            {
                playerScript.XP += XPAmount;
                Destroy(gameObject);
            }
        }
    }
}
