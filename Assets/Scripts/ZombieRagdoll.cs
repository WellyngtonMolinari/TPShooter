using UnityEngine;

public class ZombieRagdoll : MonoBehaviour
{
    private Animator animator;
    public bool isDead = false;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isDead = true;
            EnableRagdoll();
        }
    }

    public void EnableRagdoll()
    {
        if (animator != null)
        {
            animator.enabled = false;
        }
    }
}
