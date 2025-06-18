using UnityEngine;

public class TesteDanoInimigo : MonoBehaviour
{
    private Inimigo inimigo;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("AtaqueEspecial"))
        {
            int vida = inimigo.Vida 
                                - colisao.gameObject.GetComponent<AtaqueEspecial>().AtaqueDoPersonagem();
           
            inimigo.AtribuirHP(vida);
           
            Debug.Log("O personagem " +inimigo.Nome()+" tem agora "+inimigo.Vida);
        }
    }

    void Start()
    {
        inimigo = GetComponent<Inimigo>();
    }

  
    void Update()
    {
        
    }
}