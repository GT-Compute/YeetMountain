using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallDetector : MonoBehaviour
{
    public GameObject player;
    public string side = "left";
    //public string side = "Left";

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallHit(false, collision);
        var playerProp = player.gameObject.GetComponent<jumpTest>();
        if (collision.tag.Equals("ground"))
        {
            playerProp.canJump = true;
        }
    }

    private void wallHit(bool isExit, Collider2D collider)
    {
        var playerProp = player.gameObject.GetComponent<jumpTest>();
        if (collider.tag.Equals("ground"))
        {
            if (side.Equals("left"))
            {
                playerProp.canLeft = isExit;
            }
            else
            {
                playerProp.canRight = isExit;
            }
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        wallHit(true, collision);
    }
}
