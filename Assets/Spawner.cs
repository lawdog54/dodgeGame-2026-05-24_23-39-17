using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;

    float spawnInterval = 1f;

    float timer = 0f;

void SpawnFallingObject()
{
    float xPosition = Random.Range(-8f, 8f);
    Vector3 spawnPosition = new Vector3(xPosition, transform.position.y, 0f);
    Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
}
    // Update is called once per frame
    void Update()
    {
       timer += Time.deltaTime;

       if(timer >= spawnInterval)
       {
        SpawnFallingObject();
        timer = 0f;
       }
    }
}
