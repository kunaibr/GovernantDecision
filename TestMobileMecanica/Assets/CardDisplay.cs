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

        nomeText.enabled = false;
        descricaoText.enabled = false;
    }





    public void GotoRight()
    {
        Debug.Log("right");

        anim.SetFloat("dirToGo", 1);
    }

    public void GotoLeft()
    {
        Debug.Log("left");

        anim.SetFloat("dirToGo", -1);
    }


    public void Die()
    {
        controller.index++;
        Destroy(gameObject);
    }
   public bool active = false;

    public void ActiveCard()
    {
        active = true;
        nomeText.enabled = true;
        descricaoText.enabled = true;
    }
}
