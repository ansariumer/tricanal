using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointPrefabs;
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _bigPrefabs;
    [SerializeField]
    private GameObject _doublePrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPointRoutine());
        StartCoroutine(SpawnEnemyRoutine());
        StartCoroutine(SpawnBigBoRoutine());
        StartCoroutine(SpawnDoubleRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    // spawn point every 5 second 
    // creat a coroutiune of type IEnuerator -- Yield event
    // While loop

    IEnumerator SpawnPointRoutine()
    {
        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(1f, 250f), Random.Range(-4f, 10f), 0);
            Instantiate(_pointPrefabs, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }

    // Spawn enemy at every 1.5 seconds 
    // creat a coroutine of tyoe IEnumerator -- yield event 
    // while loop 

    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(1f, 250f), Random.Range(-4f, 10f), 0);
            Instantiate(_enemyPrefabs, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }

    // spawn Big bog Every 5.0 second
    // creat a corountine to type IEnumerator -- yield event 
    // while looop 

    IEnumerator SpawnBigBoRoutine()
    {
        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(60f, 250f), Random.Range(-4f, 10f), 0);
            Instantiate(_bigPrefabs, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
    }

    // spawn double every 3.0f
    // creat a corountine to type IEnumerrator -- yield event 
    // while loop

    IEnumerator SpawnDoubleRoutine()
    {
        while (true)
        {
            Vector3 posTospawn = new Vector3(Random.Range(50f, 250f), Random.Range(-4f, 10f), 0);
            Instantiate(_doublePrefab, posTospawn, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }

    // Spawn _InvisibalePrefab at every 5 seconds
    // creat a corountine to type IEnumerator -- yield event
    // while loop 


}
