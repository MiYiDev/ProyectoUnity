using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public float waitToRespawn;

    public int gemasRecogidas;

    public string nivel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCo());
    }

    IEnumerator RespawnCo()
    {
        Jugador.instance.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitToRespawn);

        Jugador.instance.gameObject.SetActive(true);

        Jugador.instance.transform.position = ChecksController.instance.spawnPoint;

        PlayerHealthController.instance.currentHealth = PlayerHealthController.instance.maxHealth;

        UIController.instance.UpdateHealthDispay();
    }

    public void AcabarNivel()
    {
        StartCoroutine(AcabarNivelCo());
    }

    public IEnumerator AcabarNivelCo()
    {
        Jugador.instance.pararMovimiento = true;

        UIController.instance.textoGanar.SetActive(true);

        yield return new WaitForSeconds(4.5f);

        SceneManager.LoadScene(nivel);
    }
}
