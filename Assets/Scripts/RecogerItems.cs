using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerItems : MonoBehaviour
{
    public bool esGema;
    public bool esCorazon;

    private bool esRecogida;

    public GameObject efectoRecoger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !esRecogida)
        {
            if (esGema)
            {
                LevelManager.instance.gemasRecogidas++;

                AudioManager.instance.PlayEfectos(4);


                UIController.instance.UpdateGemCount();

                Instantiate(efectoRecoger, transform.position, transform.rotation);

                esRecogida = true;

                Destroy(gameObject);
            }

            if (esCorazon)
            {
                if(PlayerHealthController.instance.currentHealth != PlayerHealthController.instance.maxHealth)
                {
                    PlayerHealthController.instance.GanaVida();

                    AudioManager.instance.PlayEfectos(5);


                    esRecogida = true;

                    Destroy(gameObject);
                }
            }
        }
    }
}
