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
        SceneManager.LoadScene(nivelDos);
    }

    public void NivelTres()
    {
        SceneManager.LoadScene(nivelTres);
    }
}
