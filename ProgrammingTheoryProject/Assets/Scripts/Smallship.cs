using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Smallship : Enemy
{

    private int health = 2;

    // Update is called once per frame
    void Update()
    {
       EnemyMovement(10f);
       OutofBounds();
    }


    public void OnTriggerEnter(Collider other)
    {
        health -= 1;
        Destroy(other.gameObject);
        DamageParticle();

        if (health < 1)
        {
            transform.DetachChildren();
            Destroy(gameObject);


        }
    }

}
