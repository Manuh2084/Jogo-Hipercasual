using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistema : MonoBehaviour
{

    public Queue <GameObject> Muros
    {
        get;set;
    }

    public Queue <char> TipoMuros
    {
        get;set;
    }

    public void Start()
    {
        Muros = new Queue<GameObject>();
        TipoMuros = new Queue<char>();
    }

    public void DiminuirFila(int c)
    {
        Debug.Log(TipoMuros.Peek());

        bool remover = false;

        switch(c)
        {
            case 1 :
                if('c' == TipoMuros.Peek())
                {
                    remover = true;
                }

                break;

            case 2 :
                if('q' == TipoMuros.Peek())
                {
                    remover = true;
                }

                break;

            case 3 :
                if('t' == TipoMuros.Peek())
                {
                    remover = true;
                }

                break;
        }

        if(remover)
        {
            GameObject tmp = Muros.Peek();
            remover = false;
            Destroy(tmp);
            Muros.Dequeue();
            TipoMuros.Dequeue();
        }

    }

}
