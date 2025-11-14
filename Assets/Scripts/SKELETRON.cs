using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKELETRON : MonoBehaviour
{
    public float knockbackForce = 4f;
    public float knockbackDuration = 0.1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player != null)
        {
            Debug.Log("Player is hurt");

            Vector2 direction = (player.transform.position - transform.position).normalized;
            player.Knockback(direction, knockbackForce, knockbackDuration);
        }
    }
}
