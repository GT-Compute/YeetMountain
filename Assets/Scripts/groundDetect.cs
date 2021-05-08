using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundDetect : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collsion");
        if (collision.tag.Equals("ground"))
        {
            var playercontroller = player.GetComponent<jumpTest>();
            playercontroller.canJump = true;
            Debug.Log("collion ground");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
