using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    public float pipeoffset = 10;
    private float spawnTime = 0;

    void Spawnpipe()
    {
        float lowestpoint = transform.position.y - pipeoffset;
        float highestpoint = transform.position.y + pipeoffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {

            spawnTime += Time.deltaTime;

        }
        else {

            Spawnpipe();
            spawnTime = 0;
        }
        
    }

    
}
