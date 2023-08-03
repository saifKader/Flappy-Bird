using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate = 0.7f;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if( timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
