using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    float speed = 15.0f;
    float timer = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(1,0,0) * Time.deltaTime * speed);

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            Destroy(gameObject);
            
        }

    }
}
