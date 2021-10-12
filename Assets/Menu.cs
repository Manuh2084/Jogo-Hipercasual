using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {


    }

    public void ChamaCenaDoJogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void ChamaMenuInicial()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

}