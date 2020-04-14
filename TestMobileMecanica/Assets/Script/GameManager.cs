using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float populacao = 5f;
    public float natureza = 5f;
    public float economia = 5f;

    public Slider[] slider;
   

    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }

   
    public void AlterarPontos(float populacaoC, float naturezaC, float economiaC)
    {

        populacao = populacaoC;
        AnimacaoPontosPopulacao(populacaoC);

        AnimacaoPontosNatureza(naturezaC);

        AnimacaoPontosEconomia(economiaC);
     
    }



    void AnimacaoPontosPopulacao(float pontos)
    {
        populacao += pontos;
    }
    void AnimacaoPontosNatureza(float pontos)
    {
        natureza += pontos;
    }
    void AnimacaoPontosEconomia(float pontos)
    {
        economia += pontos;
    }

    private void Update()
    {
        slider[0].value = populacao / 10;
        slider[1].value = natureza / 10;
        slider[2].value = economia / 10;

      
    }
}
