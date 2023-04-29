using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public float invincibleLength;
    private float invincibleCounter;

    private SpriteRenderer theSR;
    private void Awake()
    {
        instance = this;
    }

    public int currentHealth, maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;

            if(invincibleCounter <= 0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1);
            }
        }
    }

    public void RecibeDaño()
    {
        if (invincibleCounter <= 0)
        {
            currentHealth--;

            Jugador.instance.animator.SetTrigger("daño");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                gameObject.SetActive(false);
                LevelManager.instance.RespawnPlayer();
            }
            else
            {
                invincibleCounter = invincibleLength;
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 0.5f);
                Jugador.instance.KnockBack();
            }

            UIController.instance.UpdateHealthDispay();
        }
    }
}
