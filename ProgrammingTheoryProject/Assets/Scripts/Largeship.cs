using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Largeship : Enemy
{

    private int health = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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

        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
}
