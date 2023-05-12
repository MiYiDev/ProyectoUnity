using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasoDeNivel : MonoBehaviour
{
    public int numeroNivel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            switch (numeroNivel)
            {
                case 1:
                    if(PlayerPrefs.GetInt("nivel1Desbloqueado") == 0)
                    {
                       PlayerPrefs.SetInt("nivel1Desbloqueado", 1);
                    }
                    break;
                case 2:
                    if (PlayerPrefs.GetInt("nivel2Desbloqueado") == 0)
                    {
                        PlayerPrefs.SetInt("nivel2Desbloqueado", 1);
                    }
                    break;
                case 3:
                    if (PlayerPrefs.GetInt("nivel3Desbloqueado") == 0)
                    {
                        PlayerPrefs.SetInt("nivel3Desbloqueado", 1);
                    }
                    break;
            }
            LevelManager.instance.AcabarNivel();
            CameraScript.instance.pararCamara = true;
        }
    }
}
