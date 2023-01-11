using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float max_Y=4.5f,min_Y=-2.8f;
    public float xspawn;
    public float ySpawn;

    // Start is called before the first frame update
    void Start()
    {
        xspawn = 1f;
        xspawn = 1.5f;
        Invoke("increaser", 12);
        StartCoroutine(StartSpawning());
    }


    private void Update()
    {
        Invoke("decreaser", 15);
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(xspawn , ySpawn));
        Instantiate(obstacle);
        float y = Random.Range(min_Y, max_Y);
        obstacle.transform.position = new Vector2(transform.position.x, y);
        StartCoroutine(StartSpawning());
    }

    public void increaser()
    {
        xspawn = 4f;
        ySpawn = 7f;

    }

    void decreaser()
    {
        xspawn -= Time.deltaTime * 0.04f;
        ySpawn -= Time.deltaTime * 0.04f;
    }
}
