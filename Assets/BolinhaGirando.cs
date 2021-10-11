using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolinhaGirando : MonoBehaviour
{
    [SerializeField] private float timer;
    private float velocidade;
    private bool aumentar;

    void Start()
    {
        velocidade = 100;
        aumentar = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * velocidade * Time.deltaTime , Space.Self);
        if (aumentar)
            StartCoroutine(AumentarVelocidade());
    }
    IEnumerator AumentarVelocidade()
    {
        aumentar = false;
        yield return new WaitForSeconds(timer);
        velocidade += velocidade /10;
        aumentar = true;
    }
}
