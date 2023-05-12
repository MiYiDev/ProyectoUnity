using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarNivel : MonoBehaviour
{
    public string menuInicio;
    public string nivelUno;
    public string nivelDos;
    public string nivelTres;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void VolverAtras()
    {
        SceneManager.LoadScene(menuInicio);
    }

    public void NivelUno()
    {
        SceneManager.LoadScene(nivelUno);
    }

    public void NivelDos()
    {
        if(PlayerPrefs.GetInt("nivel1Desbloqueado") == 1)
        {
            SceneManager.LoadScene(nivelDos);
        }
    }

    public void NivelTres()
    {
        if(PlayerPrefs.GetInt("nivel2Desbloqueado") == 1)
        SceneManager.LoadScene(nivelTres);
    }

    public void QuitarMusica()
    {
        if(PlayerPrefs.GetInt("quitarMusica") == 1)
        {
            PlayerPrefs.SetInt("quitarMusica", 0);
        }
        if (PlayerPrefs.GetInt("quitarMusica") == 0)
        {
            PlayerPrefs.SetInt("quitarMusica", 1);
        }
    }


    public void QuitarEfectos()
    {
        if (PlayerPrefs.GetInt("quitarEfectos") == 1)
        {
            PlayerPrefs.SetInt("quitarEfectos", 0);
        }
        if (PlayerPrefs.GetInt("quitarEfectos") == 0)
        {
            PlayerPrefs.SetInt("quitarEfectos", 1);
        }
    }
}
