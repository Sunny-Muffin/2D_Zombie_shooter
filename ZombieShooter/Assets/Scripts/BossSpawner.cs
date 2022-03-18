using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    //public enum SpawnState { SPAWNING, WAITING, COUNTING };

    /*[SerializeField]
    private AudioSource _audioSource;

    [SerializeField]
    private AudioManager _audioManager;*/

    /*[System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    private float waveCountdown;

    private float searchCountdown = 1f;

    public SpawnState state = SpawnState.COUNTING;

    // Start is called before the first frame update
    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            // Check if enemies are still alive
            if (!EnemyIsAlive())
            {
                // Begin a countdown for next wave
                StartNewWave();
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                // Start spawning wave
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void StartNewWave()
    {
        // Debug.Log("Wave Completed! Starting a new one");
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            // Debug.Log("All waves completed! Looping...");
            // Here I can put new waves or new scenes or make more enemie by multiplying etc.
        }
        else
        {
            nextWave++;
        }
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;

        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("Boss").Length == 0)
            {
                return false;
            }
        }
        return true;
    }


    IEnumerator SpawnWave(Wave _wave)
    {
        // Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.SPAWNING;
        //for (int i = 0; i < _wave.count; i++)
        //{
            SpawnEnemy(_wave.enemy);
            //yield return new WaitForSeconds(1 / _wave.rate);
        //}


        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        // spawn enemy
        // Debug.Log("Spawning enemy: " + _enemy.name);
        Instantiate(_enemy, transform.position, transform.rotation);
        //_audioManager.Play("BossSpawnSound");
    }
    */
}
