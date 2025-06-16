using UnityEngine;

public class InimigoManager : MonoBehaviour
{

    public Animator animator;
    private  MovimentoInimigo Slime;
    public float animSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Slime = GetComponent<MovimentoInimigo>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Perseguindo",Slime.Perseguindo);
        animator.speed = animSpeed;
    }
}