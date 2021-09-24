using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    private float speed = 10.0f;

    [SerializeField]
    private GameObject bullets;
    // ENCAPSULATION
    public GameObject Bullets
    {
        get
        {
            return bullets;
        }
        set
        {
            bullets = value;
        }
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


    // ABSTRACTION
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullets, transform.position + Vector3.right * 0.5f, Quaternion.identity);
            Debug.Log("shoot");

        }


    }


}

