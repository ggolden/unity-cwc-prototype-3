using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacle;
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;

    private PlayerConttoller playerControllerScript;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerConttoller>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            int obstacleSelection = Random.RandomRange(0, obstacle.Length);
            Instantiate(obstacle[obstacleSelection], spawnPosition, obstacle[obstacleSelection].transform.rotation);
        }
    }
}
