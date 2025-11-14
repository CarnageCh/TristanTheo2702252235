using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player != null)
        {
            player.numPumpkin++;
            Destroy(this.gameObject);
            Debug.Log("Crop Harvested: Pumpkin");
        }
    }
}
