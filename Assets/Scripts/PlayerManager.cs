using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public Animator animator;
    private  MovimentoDoPlayer Guerreiro;
    public float animSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Guerreiro = GetComponent<MovimentoDoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetTrigger("Ataque");
        }
        animator.SetBool("Andando",Guerreiro.Andando);
        animator.speed = animSpeed;

    }
    
}