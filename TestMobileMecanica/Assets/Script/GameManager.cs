using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float populacao = 5f;
    public float natureza = 5f;
    public float economia = 5f;

    public Animator[] anim;

    public Text textCartas;
    public Text textGameOver;
    public GameObject panelGameOver;

    public Slider[] slider;

    int qtdCartas = 0;

    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }

   
    public void AlterarPontos(float populacaoC, float naturezaC, float economiaC)
    {

        StartCoroutine("AnimacaoPontosPopulacao",populacaoC);

        StartCoroutine("AnimacaoPontosNatureza", naturezaC);

        StartCoroutine("AnimacaoPontosEconomia", economiaC);
     
    }



    IEnumerator AnimacaoPontosPopulacao(float pontos)
    {
        populacao += pontos;

        if(pontos > 0)
            anim[0].SetTrigger("plus");

        if(pontos < 0)
            anim[0].SetTrigger("minus");

        yield return new WaitForSeconds(0);
        verify();
    }
    IEnumerator AnimacaoPontosNatureza(float pontos)
    {
        natureza += pontos;

        if (pontos > 0)
            anim[1].SetTrigger("plus");

        if (pontos < 0)
            anim[1].SetTrigger("minus");

        yield return new WaitForSeconds(0);

        verify();
    }
    IEnumerator AnimacaoPontosEconomia(float pontos)
    {
        economia += pontos;

        if (pontos > 0)
            anim[2].SetTrigger("plus");

        if (pontos < 0)
            anim[2].SetTrigger("minus");

        yield return new WaitForSeconds(0);

        verify();
    }


    void verify()
    {
        if (populacao < 0)
        {
            GameOver("Todos foram embora da sua cidade!");
            populacao = 0;
        }

        if (economia < 0)
        {
            GameOver("Você ficou sem dinheiro!");
            economia = 0;
        }

        if (natureza < 0)
        {
            GameOver("Sua cidade ficou suja e sem árvores!");
            natureza = 0;
        }


        if (populacao > 10)
        {
            GameOver("Sua cidade ficou com uma super população!");

            populacao = 10;
        }

        if (economia > 10)
        {
            GameOver("Sua cidade ficou rica, porém muitos ladrões apareceram!");

            economia = 10;
        }

        if (natureza > 10)
        {
            GameOver("As arvores e animais dominaram as ruas da sua cidade!");

            natureza = 10;
        }

        slider[0].value = populacao;
        slider[1].value = natureza;
        slider[2].value = economia;
    }

 

    void GameOver(string text)
    {
        panelGameOver.SetActive(true);
        textGameOver.text = text;
    }

    public void Sair()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Denovo()
    {
        SceneManager.LoadScene("Game");
    }

    public void AddCards()
    {
        qtdCartas++;

        textCartas.text = "Cartas Tiradas: " + qtdCartas.ToString();

    }

}
