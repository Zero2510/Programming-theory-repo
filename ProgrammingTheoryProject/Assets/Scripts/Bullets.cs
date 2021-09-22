using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private float speed = 15.0f;
    private float timer = 2.0f;

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
