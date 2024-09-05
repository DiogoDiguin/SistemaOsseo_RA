using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    [SerializeField] private GameObject heart;
    private bool isPlaying = true;
    void Start()
    {
        // Certifique-se de que o Animator está atribuído
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    public void BtnStartStopAnimation()
    {
        if (isPlaying)
        {
            animator.speed = 0; // Pausar a animação
        }
        else
        {
            animator.speed = 1; // Continuar a animação
        }
        isPlaying = !isPlaying;
    }
}
