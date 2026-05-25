using UnityEngine;

public class fallingObject : MonoBehaviour
{
    float fallSpeed;
    float destroyY = -6f;

        void Start()
    {
    
        fallSpeed = Random.Range(2f, 8f);
    }

    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
         if(transform.position.y < destroyY)
         {
          Destroy(gameObject);
         }
    }
}
