using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolinhaGirando : MonoBehaviour
{

    public float velocidade;
    public float modVel;
    public float velocidadeMax;

    void Start()
    {

    }


    void Update()
    {
        velocidade = Mathf.Clamp(
            velocidade + modVel * Time.deltaTime,
            0,
            velocidadeMax
        );

        transform.Rotate(Vector3.back * velocidade * Time.deltaTime , Space.Self);
    }

}
