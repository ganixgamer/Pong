using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    [SerializeField]
    float velocidade = 0.5f;  // unidades por segundo

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;

    void Update()
    {
        if (Input.GetKey(upKey))
        {
            //sobe
            //transform.position =
            transform.position += velocidade * Vector3.up * Time.deltaTime;
        }
         
         else if (Input.GetKey(downKey))
        {
            //desce
            //transform.position =
            transform.position += velocidade * Vector3.down * Time.deltaTime; //para depender do tempo e não dos frames
        }

        float cameraHeight = Camera.main.orthographicSize;
         float halfpaddleSize = 0.5f;     // inves de repetir o mesmo valor e tb mais pratico mexer com o valor da camara. fazer uma variavel cameraHeight

        if (transform.position.y >= cameraHeight - halfpaddleSize)   //para impedir que o stick sai das extremidades
        {
            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - halfpaddleSize;
            transform.position = positionAux;


        }

        if (transform.position.y <= -cameraHeight + halfpaddleSize)   //para impedir que o stick sai das extremidades
        {
            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + halfpaddleSize;
            transform.position = positionAux;


        }
    }
}










