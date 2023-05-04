using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static MenuPausa instance;

    public string seleccionarNivel, menuPrincipal;

    public GameObject panelPausa;
    public bool estaPausado;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Pausar();
        }
    }

    public void Pausar()
    {
        if (estaPausado)
        {
            estaPausado = false;
            panelPausa.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            estaPausado = true;
            panelPausa.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void SeleccionarNivel()
    {
        SceneManager.LoadScene(seleccionarNivel);
        Time.timeScale = 1;
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(menuPrincipal);
        Time.timeScale = 1;
    }
}
