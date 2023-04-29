using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecksController : MonoBehaviour
{
    public static ChecksController instance;

    public CheckPoint[] checkPoints;

    public Vector3 spawnPoint;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        checkPoints = FindObjectsOfType<CheckPoint>();

        spawnPoint = Jugador.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DesactivarCheckpoints()
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].ResetCheckpoint();
        }
    }

    public void setSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }
}
