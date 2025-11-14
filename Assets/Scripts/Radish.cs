using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player != null)
        {
            player.numRadish++;
            Destroy(this.gameObject);
            Debug.Log("Crop Harvested: Radish");
        }
    }
}
