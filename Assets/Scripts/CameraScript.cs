using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public static CameraScript instance;

    public GameObject foxy;

    public Transform farBackground, middleBackground;

    public bool pararCamara;

    private Vector2 lastPos;

    public float minHeight, maxHeight;

    public Transform noAvanzar;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pararCamara)
        {

            if (foxy.transform.position.x > noAvanzar.transform.position.x)
            {
                Vector3 position = transform.position;
                position.x = foxy.transform.position.x;
                position.y = Mathf.Clamp(foxy.transform.position.y, minHeight, maxHeight);
                transform.position = position;

                //transform.position = new Vector3(foxy.transform.position.x, Mathf.Clamp(foxy.transform.position.y, minHeight, maxHeight), foxy.transform.position.z);
            }

            //Vector2 positionBg = fondo.material.mainTextureOffset;
            //positionBg.x = foxy.transform.position.x * 0.01f;
            //fondo.material.mainTextureOffset = positionBg;

            //float amountToMoveX = transform.position.x - lastXPos;

            Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);

            farBackground.position = farBackground.position + new Vector3(amountToMove.x, amountToMove.y, 0f);
            middleBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0) * 0.5f;

            lastPos = transform.position;
        }
    }
}
