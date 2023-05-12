using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string escena;
    public string estadisticas;
    public string opciones;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmpezarJuego()
    {
        SceneManager.LoadScene(escena);
    }

    public void SalirJuego()
    {
        Application.Quit();
    }

    public void MostrarEstadisticas()
    {
        SceneManager.LoadScene(estadisticas);
    }

    public void MostrarOpciones()
    {
        SceneManager.LoadScene(opciones);
    }
}
