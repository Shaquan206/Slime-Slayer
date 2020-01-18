using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Slider healthSlider;

    private GameObject player;

    public Rigidbody2D rb;

    // Enemy Stats
    public float moveSpeed;
    public int health;
    public int damage;
    public int XPAmount;
    public float despawnRange;

    // Game Manager
    private GameObject gameManager;
    private GameManager gameManagerScript;

    private void Start()
    {
        // Get Game Manager Componet
        gameManager = GameObject.Find("Game Manager");
        gameManagerScript = gameManager.GetComponent<GameManager>();

        // Add A Entidy
        gameManagerScript.entitys++;

        // Get Player GameObject 
        player = GameObject.Find("Player");
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    private void Update()
    {
        healthSlider.value = health;
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance > despawnRange)
        {
            gameManagerScript.entitys--;
            Destroy(gameObject);
        }
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
                gameManagerScript.entitys--;
                playerScript.XP += XPAmount;
                Destroy(gameObject);
            }
        }
    }
}
