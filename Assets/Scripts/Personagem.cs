using System.Collections;
using UnityEditor;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ] 
    public int Vida;
    [ SerializeField ]
    private int dano_ataque;
    [ SerializeField ]
    private float velocidade;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirHP(int Vida)
    {
        this.Vida = Vida;
    }

    public int HP()
    {
        return this.Vida;
    }

    public void AtribuirDano(int dano_ataque)
    {
        this.dano_ataque = dano_ataque;
    }

    public int Dano()
    {
        return this.dano_ataque;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }
    





    void Start()
    {
        
    }
    void Update()
    {
        
    }
}