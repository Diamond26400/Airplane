using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public float ObstacleSpeed;
    public float spawnInterval;
    public GameObject ObstaclePreferb;
    // Start is called before the first frame update
    IEnumerator SpawnObstacle()
    {
        while (true) 
        {
            Instantiate( ObstaclePreferb , transform.position, Quaternion.identity);
            yield return new
                WaitForSeconds(spawnInterval);
        }
    }
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
