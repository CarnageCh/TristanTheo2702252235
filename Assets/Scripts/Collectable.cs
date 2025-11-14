using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player != null)
        {
            player.numCabbages++;
            Destroy(this.gameObject);
            Debug.Log("Crop Harvested: Cabbage");
        }
    }
}
