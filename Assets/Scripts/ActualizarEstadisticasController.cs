using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarEstadisticasController : MonoBehaviour
{
    public Text enemigosMatados;
    public Text vecesMuertas;
    public Text gemasRecogidas;
    public Text corazonesRecogidos;
    public Text dinosAsesinados;
    public Text saposAsesinados;

    // Start is called before the first frame update
    void Start()
    {
        enemigosMatados.text = PlayerPrefs.GetInt("enemigosMatados").ToString();
        vecesMuertas.text = PlayerPrefs.GetInt("vecesMuertas").ToString();
        gemasRecogidas.text = PlayerPrefs.GetInt("gemasRecord").ToString();
        corazonesRecogidos.text = PlayerPrefs.GetInt("corazonRecord").ToString();
        dinosAsesinados.text = PlayerPrefs.GetInt("dinosMatados").ToString();
        saposAsesinados.text = PlayerPrefs.GetInt("saposMatados").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
