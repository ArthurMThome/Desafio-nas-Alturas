using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject FundoGameOver;
    [SerializeField]
    private Text valorRecorde;
    [SerializeField]
    private Image imagemMedalha;
    [SerializeField]
    private Sprite medalhaOuro;
    [SerializeField]
    private Sprite medalhaPrata;
    [SerializeField]
    private Sprite medalhaBronze;

    private int recorde;
    private Pontuacao pontuacao;

    private void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    public void MostrarInterface()
    {
        this.AtualizarInterfaceGrafica();
        this.FundoGameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        this.FundoGameOver.SetActive(false);
    }

    private void AtualizarInterfaceGrafica()
    {
        this.recorde = PlayerPrefs.GetInt("recorde");
        this.valorRecorde.text = recorde.ToString();
        this.VerificarCorMedalha();
    }

    private void VerificarCorMedalha()
    {
        if(this.pontuacao.Pontos >= this.recorde)
        {
            //medalha ouro
            this.imagemMedalha.sprite = this.medalhaOuro;
        } else if(this.pontuacao.Pontos >= this.recorde / 2)
        {
            //medalha prata
            this.imagemMedalha.sprite = this.medalhaPrata;
        } else
        {
            //medalha bronze
            this.imagemMedalha.sprite = this.medalhaBronze;
        }
    }
}
