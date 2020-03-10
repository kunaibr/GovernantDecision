using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Image imagem;
    public Text nomeText;
    public Text descricaoText;

    private void Start()
    {
        imagem.sprite = card.imagem;
        nomeText.text = card.nome;
        descricaoText.text = card.descricao;
    }
}
