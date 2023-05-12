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

                Debug.Log(LevelManager.instance.gemasRecogidas);

                AudioManager.instance.PlayEfectos(4);

                PlayerPrefs.SetInt("gemasRecord", PlayerPrefs.GetInt("gemasRecord") + 1);

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

                    PlayerPrefs.SetInt("corazonRecord", PlayerPrefs.GetInt("corazonRecord") + 1);

                    esRecogida = true;

                    Destroy(gameObject);
                }
            }
        }
    }
}
