using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoClicando : MonoBehaviour
{
    private SpriteRenderer imagem;

    private void Awake()
    {
        this.imagem = this.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Desaparecer();
        }
    }

    public void Desaparecer()
    {
        if (this.imagem.enabled == true)
        {
            this.imagem.enabled = false;
        }
    }
        
}
