using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawnLeft;
    public Transform spawn;
    public Transform spawnRight;

    public GameObject enemy;

    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawn", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemySpawn()
    {
        int randNum = Random.Range(1, 4);
        if(randNum == 1)
        {
            Instantiate(enemy, spawnLeft);
        }
        else if(randNum == 2)
        {
            Instantiate(enemy, spawn);
        }
        else
        {
            Instantiate(enemy, spawnRight);
        }
    }

   
}
