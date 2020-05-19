using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TouchController controller;

    public Image imagem;
    public Text nomeText;
    public Text descricaoText;
    public Animator anim;
    private void Start()
    {
        imagem.sprite = card.imagem;
        nomeText.text = card.nome;
        descricaoText.text = card.descricao;
        anim = GetComponent<Animator>();
        controller = GameObject.FindGameObjectWithTag("Controller").GetComponent<TouchController>();
     
    }



    bool active = false;

    public void GotoRight()
    {
        if (!active)
        {
            active = true;
            GameManager.Instance.AlterarPontos(card.populacaoA, card.naturezaA, card.economiaA);
            GameManager.Instance.AddCards();
           anim.SetFloat("dirToGo", 1);
        }
    }

    public void GotoLeft()
    {
        if (!active)
        {
            active = true;
     
             GameManager.Instance.AlterarPontos(card.populacaoN, card.naturezaN, card.economiaN);
            GameManager.Instance.AddCards();

            anim.SetFloat("dirToGo", -1);
        }

    }


    public void Die()
    {
        controller.Next();
        Destroy(gameObject);
    }


    public void ActiveCard()
    {
        nomeText.enabled = true;
        descricaoText.enabled = true;
    }
}
