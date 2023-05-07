using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    public GameObject deathEffect;
        
    [Range(0,100)]
    public float dropProbability;

    public GameObject collectible;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            other.transform.parent.gameObject.SetActive(false);
            AudioManager.instance.PlayEfectos(2);
            Jugador.instance.Bounce();
            Instantiate(deathEffect, other.transform.position, other.transform.rotation);

            float dropSelect = Random.Range(0, 100);

            if(dropSelect <= dropProbability)
            {
                Instantiate(collectible, other.transform.position, other.transform.rotation);
            }

        }
    }
}
