using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public GameObject redSlimePrefab;
    public GameObject redSlimeSpawnPoint;
    public float redSlimeSpawnRate;
    public float redSlimeSpawnRange;
    public bool isSpawningRedSlime;

    public GameObject blueSlimePrefab;
    public GameObject blueSlimeSpawnPoint;
    public float blueSlimeSpawnRate;
    public float blueSlimeSpawnRange;
    public bool isSpawningBlueSlime;

    public GameObject greenSlimePrefab;
    public GameObject greenSlimeSpawnPoint;
    public float greenSlimeSpawnRate;
    public float greenSlimeSpawnRange;
    public bool isSpawningGreenSlime;

    public GameObject yellowSlimePrefab;
    public GameObject yellowSlimeSpawnPoint;
    public float yellowSlimeSpawnRate;
    public float yellowSlimeSpawnRange;
    public bool isSpawningYellowSlime;

    public GameObject pinkSlimePrefab;
    public GameObject pinkSlimeSpawnPoint;
    public float pinkSlimeSpawnRate;
    public float pinkSlimeSpawnRange;
    public bool isSpawningPinkSlime;

    public GameObject orangeSlimePrefab;
    public GameObject orangeSlimeSpawnPoint;
    public float orangeSlimeSpawnRate;
    public float orangeSlimeSpawnRange;
    public bool isSpawningOrangeSlime;



    private void Update()
    {
        if (isSpawningRedSlime == false)
        {
            float dist = Vector3.Distance(redSlimeSpawnPoint.transform.position, player.transform.position);
            if (dist < redSlimeSpawnRange)
            {
                StartCoroutine(SpawnRedSlime());
            }
        }

        if (isSpawningBlueSlime == false)
        {
            float dist = Vector3.Distance(blueSlimeSpawnPoint.transform.position, player.transform.position);
            if (dist < blueSlimeSpawnRange)
            {
                StartCoroutine(SpawnBlueSlime());
            }
        }

        if (isSpawningGreenSlime == false)
        {
            float dist = Vector3.Distance(greenSlimeSpawnPoint.transform.position, player.transform.position);
            if (dist < greenSlimeSpawnRange)
            {
                StartCoroutine(SpawnGreenSlime());
            }
        }

        if (isSpawningYellowSlime == false)
        {
            float dist = Vector3.Distance(yellowSlimeSpawnPoint.transform.position, player.transform.position);
            if (dist < yellowSlimeSpawnRange)
            {
                StartCoroutine(SpawnYellowSlime());
            }
        }

        if (isSpawningPinkSlime == false)
        {
            float dist = Vector3.Distance(pinkSlimeSpawnPoint.transform.position, player.transform.position);
            if (dist < pinkSlimeSpawnRange)
            {
                StartCoroutine(SpawnPinkSlime());
            }
        }

        if (isSpawningOrangeSlime == false)
        {
            float dist = Vector3.Distance(orangeSlimeSpawnPoint.transform.position, player.transform.position);
            if (dist < orangeSlimeSpawnRange)
            {
                StartCoroutine(SpawnOrangeSlime());
            }
        }
    }

    IEnumerator SpawnRedSlime()
    {
        isSpawningRedSlime = true;
        yield return new WaitForSeconds(redSlimeSpawnRate);
        Instantiate(redSlimePrefab, redSlimeSpawnPoint.transform.position + new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
        isSpawningRedSlime = false;
    }

    IEnumerator SpawnBlueSlime()
    {
        isSpawningBlueSlime = true;
        yield return new WaitForSeconds(blueSlimeSpawnRate);
        Instantiate(blueSlimePrefab, blueSlimeSpawnPoint.transform.position + new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
        isSpawningBlueSlime = false;
    }

    IEnumerator SpawnGreenSlime()
    {
        isSpawningGreenSlime = true;
        yield return new WaitForSeconds(greenSlimeSpawnRate);
        Instantiate(greenSlimePrefab, greenSlimeSpawnPoint.transform.position + new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
        isSpawningGreenSlime = false;
    }

    IEnumerator SpawnYellowSlime()
    {
        isSpawningYellowSlime = true;
        yield return new WaitForSeconds(yellowSlimeSpawnRate);
        Instantiate(yellowSlimePrefab, yellowSlimeSpawnPoint.transform.position + new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
        isSpawningYellowSlime = false;
    }

    IEnumerator SpawnPinkSlime()
    {
        isSpawningPinkSlime = true;
        yield return new WaitForSeconds(pinkSlimeSpawnRate);
        Instantiate(pinkSlimePrefab, pinkSlimeSpawnPoint.transform.position + new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
        isSpawningPinkSlime = false;
    }

    IEnumerator SpawnOrangeSlime()
    {
        isSpawningOrangeSlime = true;
        yield return new WaitForSeconds(orangeSlimeSpawnRate);
        Instantiate(orangeSlimePrefab, orangeSlimeSpawnPoint.transform.position + new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
        isSpawningOrangeSlime = false;
    }
}
