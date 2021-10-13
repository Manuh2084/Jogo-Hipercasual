using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour
{
    public float modificadorVelocidade;

    public float velocidade;

    public float velocidadeMaxima;

    public GameObject pauseButton;

    public AudioSource tapSom;

    private void Update()
    {
        velocidade = Mathf.Clamp(
            velocidade + modificadorVelocidade * Time.deltaTime,
            0,
            velocidadeMaxima
        );
    }

    public void ReiniciarJogo()
    {
	pauseButton.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
    }

    public void Pause()
    {

        Time.timeScale = 0;

        pauseButton.SetActive(true);
        
    }

    public void UnPause()
    {
        Time.timeScale = 1;

        pauseButton.SetActive(false);
    }

    public void TapSong()
    {
        tapSom.Play();
    }

}