using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int numCabbages = 0;
    public int numCauliflower = 0;
    public int carrat = 0;
    public int numPumpkin = 0;
    public int numPotato = 0;
    public int numWheat = 0;
    public int numRadish = 0;

    private Rigidbody2D rb;
    private Movement movement;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
        animator = GetComponent<Animator>();
    }

    public void Knockback(Vector2 direction, float force, float duration)
    {
        StartCoroutine(ApplyKnockback(direction, force, duration));
    }

    private IEnumerator ApplyKnockback(Vector2 direction, float force, float duration)
    {
        float timer = 0f;

        // Disable player movement
        movement.enabled = false;

        // Play hurt animation
        if (animator != null)
        {
            animator.SetBool("IsHurt", true);
            animator.SetBool("IsMoving", false); // stop walk animation
        }

        while (timer < duration)
        {
            rb.MovePosition(rb.position + direction * force * Time.fixedDeltaTime);
            timer += Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();
        }

        // End hurt animation
        if (animator != null)
            animator.SetBool("IsHurt", false);

        // Re-enable player movement
        movement.enabled = true;
    }
}