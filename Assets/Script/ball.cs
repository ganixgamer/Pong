using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    float tempo;
    float tempoaadicionar;
    bool bolafoilancada = false;
    // Start is called before the first frame update
    void Start()

    {

    }
 // Update is called once per frame
    void Update()

     
    {
        tempoaadicionar = Time.deltaTime;
        tempo += tempoaadicionar;
        Debug.Log(tempo);
        if (bolafoilancada == false)
            if (tempo >= 2f)
            {
                if (tempo >= 2f)
                {
                    GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
                    bolafoilancada = true;


                }

            } 
    
    }
}