using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject redSlimePrefab;
    public GameObject redSlimeSpawnPoint;
    public float redSlimeSpawnRate;
    public bool isSpawningRedSlime;

    public GameObject blueSlimePrefab;
    public GameObject blueSlimeSpawnPoint;
    public float blueSlimeSpawnRate;
    public bool isSpawningBlueSlime;


    private void Update()
    {
        if (isSpawningRedSlime == false)
        {
            StartCoroutine(SpawnRedSlime());
        }

        if (isSpawningBlueSlime == false)
        {
            StartCoroutine(SpawnBlueSlime());
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

}
