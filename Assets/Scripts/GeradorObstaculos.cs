using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarFacil;
    [SerializeField]
    private float tempoParaGerarDificil;
    [SerializeField]
    private GameObject manualInstrucoes;
    private float cronometro;
    private ControleDificuldade dificuldade;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerarFacil;
    }

    private void Start()
    {
        this.dificuldade = GameObject.FindObjectOfType<ControleDificuldade>();
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.manualInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp(this.tempoParaGerarFacil, this.tempoParaGerarDificil, this.dificuldade.Dificuldade);
        }
    }
}
