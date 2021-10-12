using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorMuros : MonoBehaviour
{
    public GameObject[] muroPrefabs;

    public float delayInicial;

    public float delayEntreMuros;

    public Sistema sistema;

    private void Start()
    {
        InvokeRepeating("GerarMuro", delayInicial, delayEntreMuros);
    }

    private void GerarMuro()
    {
        var quantidadeMuros = muroPrefabs.Length;
        var indiceAleatorio = Random.Range(0, quantidadeMuros);
        var muroPrefab = muroPrefabs[indiceAleatorio];
        var instancia = Instantiate(muroPrefab, transform.position, Quaternion.identity);
        sistema.Muros.Enqueue(instancia);
        sistema.TipoMuros.Enqueue(instancia.GetComponent<Movimentar>().tipoMuro);
    }

}