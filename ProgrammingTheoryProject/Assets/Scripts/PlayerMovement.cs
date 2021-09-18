using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    float speed = 10.0f;
    Rigidbody rb;
    public GameObject bullets;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, moveY, 0);

        transform.Translate(movement * Time.deltaTime * speed);

        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullets, rb.position + Vector3.forward * 0.5f, Quaternion.identity);
            Debug.Log("shoot");

        }


    }


}

