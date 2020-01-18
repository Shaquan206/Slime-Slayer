using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadNewGameScene()
    {
        GlobalControl.Instance.level = 0;
        GlobalControl.Instance.XP = 0;
        GlobalControl.Instance.damage = 1;
        GlobalControl.Instance.health = 10;
        GlobalControl.Instance.maxHealth = 10;
        GlobalControl.Instance.regenerateSpeed = 1;
        GlobalControl.Instance.attackSpeed = 1;
        GlobalControl.Instance.attackTime = 0.05f;
        SceneManager.LoadScene("GameScene");
    }
}
