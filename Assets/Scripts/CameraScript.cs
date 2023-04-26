using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject foxy;
    public Renderer fondo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(foxy.transform.position.x > -17)
        {
            Vector3 position = transform.position;
            position.x = foxy.transform.position.x;
            transform.position = position;
        }

        Vector2 positionBg = fondo.material.mainTextureOffset;
        positionBg.x = foxy.transform.position.x * 0.01f;
        fondo.material.mainTextureOffset = positionBg;
    }
}
