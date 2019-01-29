using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDificuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoDificuldadeMaxima;
    private float tempoPassado = 0;
    public float Dificuldade { get; private set; }

    // Update is called once per frame
    void Update()
    {
        this.tempoPassado += Time.deltaTime;
        this.Dificuldade = this.tempoPassado / this.tempoDificuldadeMaxima;
        this.Dificuldade = Mathf.Min(1, this.Dificuldade);
    }
}
