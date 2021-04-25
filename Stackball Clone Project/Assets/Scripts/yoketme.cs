using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoketme : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject pause;
    public bool Paused = false;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "ball")
        {
            Destroy(player.gameObject);
            
        }
    }
}
