using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    public Rigidbody2D rb;

    public float pontos;

    private float highscore;

    public float multiplicadorPontos = 1;

    public Text pontosText;

    public Text highscoreText;

    public AudioSource fimDeJogoAudioSource;

    public GameObject botaoReiniciar;

    public GameObject fimDeJogo;

    public Text pontosFinais;

    private void Start()
    {
        highscore = PlayerPrefs.GetFloat("HIGHSCORE");
        highscoreText.text = $"HIGHSCORE {Mathf.FloorToInt(highscore)}";
    }

    void Update()
    {
        pontos += Time.deltaTime * multiplicadorPontos;

        var pontosArredondado = Mathf.FloorToInt(pontos);
        pontosText.text = pontosArredondado.ToString();
        pontosFinais.text = pontosArredondado.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            if (pontos > highscore)
            {
                highscore = pontos;

                PlayerPrefs.SetFloat("HIGHSCORE", highscore);
            }

            fimDeJogoAudioSource.Play();

            botaoReiniciar.SetActive(true);

            fimDeJogo.SetActive(true);

            Time.timeScale = 0;
        }
    }

}