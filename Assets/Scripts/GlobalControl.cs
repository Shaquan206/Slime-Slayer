using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public float moveSpeed;
    public int level;
    public int XP;

    public int damage;
    public int health;
    public int maxHealth;

    public float regenerateSpeed;

    public float attackSpeed;
    public float attackTime;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
