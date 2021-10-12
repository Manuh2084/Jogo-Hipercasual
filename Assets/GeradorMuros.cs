using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorMuros : MonoBehaviour
{
    public GameObject[] muroPrefabs;

    public float delayInicial;

    public float delayEntreMuros;

    private void Start()
    {
        InvokeRepeating("GerarMuro", delayInicial, delayEntreMuros);
    }

    private void GerarMuro()
    {
        var quantidadeMuros = muroPrefabs.Length;
        var indiceAleatorio = Random.Range(0, quantidadeMuros);
        var muroPrefab = muroPrefabs[indiceAleatorio];
        Instantiate(muroPrefab, transform.position, Quaternion.identity);
    }

}