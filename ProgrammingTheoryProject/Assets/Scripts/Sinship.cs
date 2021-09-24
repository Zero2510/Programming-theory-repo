using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Sinship : Enemy
{

    private int health = 1;

    // Update is called once per frame
    void Update()
    {

      EnemyMovement(5f);
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

    // POLYMORPHISM
    public override void EnemyMovement(float speed)
    {
        transform.Translate(new Vector3(1, Mathf.Sin(Time.time),0) * Time.deltaTime * speed);
        transform.Rotate(new Vector3(1, 0, 0), 0.5f, Space.Self);
    }


}
