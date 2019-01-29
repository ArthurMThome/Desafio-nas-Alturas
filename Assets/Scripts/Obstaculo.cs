using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;
    private Vector3 posicaoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;
    private float posicaoPontuacao = -2f;

    private void Start()
    {
        this.posicaoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-1.10f, 1.95f));
    }
    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade.valor * Time.deltaTime);
        if(!this.pontuei && this.transform.position.x < (this.posicaoAviao.x + posicaoPontuacao))
        {
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        this.Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
