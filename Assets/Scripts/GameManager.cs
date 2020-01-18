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

}
