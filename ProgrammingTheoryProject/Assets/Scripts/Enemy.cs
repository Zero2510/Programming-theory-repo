using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem damage;


    public virtual void EnemyMovement(float speed)
    {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
    }


    protected void OutofBounds()
    {
        if(transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

    protected void DamageParticle()
    {
        damage.Play();
    }

}
