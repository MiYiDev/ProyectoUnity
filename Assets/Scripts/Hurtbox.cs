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
        if(other.tag == "Dino" || other.tag == "Sapo")
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

            if (other.tag == "Dino")
            {
                PlayerPrefs.SetInt("dinosMatados", PlayerPrefs.GetInt("dinosMatados") + 1);
            }
            if (other.tag == "Sapo")
            {
                PlayerPrefs.SetInt("saposMatados", PlayerPrefs.GetInt("saposMatados") + 1);
            }

            PlayerPrefs.SetInt("enemigosMatados", PlayerPrefs.GetInt("enemigosMatados") + 1);
        }
    }
}
