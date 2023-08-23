using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTubeSpawnerBehaviourScript : MonoBehaviour
{
    public GameObject yellowTube;
    public float spawnRate;
    public float heightOffSet;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTube();
    }

    // Update is called once per frame
    void Update()
    {
        // Timer
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnTube(); 
            timer = 0;
        }
    }

    void SpawnTube()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;

        Instantiate(yellowTube,
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation);
    }
}
