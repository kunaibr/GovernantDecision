using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Card",menuName ="Card" )]
public class Card : ScriptableObject
{
    public Sprite imagem;
    public string nome;
    public string descricao;

    [Header("Pontos Aceitar")]
    public int populacaoA;
    public int naturezaA;
    public int economiaA;

    [Header("Pontos Negar")]
    public int populacaoN;
    public int naturezaN;
    public int economiaN;


}
