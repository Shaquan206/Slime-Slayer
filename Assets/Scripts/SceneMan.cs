using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    private bool isPaused;

    public void LoadGameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void LoadNewGameScene()
    {
        Time.timeScale = 1;
        GlobalControl.Instance.moveSpeed = 5;
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

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Pause()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }

        else if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
