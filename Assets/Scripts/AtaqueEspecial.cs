using UnityEngine;

public class AtaqueEspecial : MonoBehaviour
{
    public Personagem personagem;
    private int ataque;
    

    public int AtaqueDoPersonagem()
    {
        ataque = personagem.Dano();
        return ataque;
    }
}