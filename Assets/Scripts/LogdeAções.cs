            using System;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            int Vida = personagem.HP() - colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();
           
            personagem.AtribuirHP(Vida);
           
            Debug.Log("O personagem " +personagem.Nome()+" tem agora "+personagem.HP());
        }
    }

    void Start()
    {
        personagem = GetComponent<Personagem>();
    }

  
    void Update()
    {
        
    }
}