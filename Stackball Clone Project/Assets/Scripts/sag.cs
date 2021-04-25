using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sag : MonoBehaviour
{
    
    bool ground = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ground)
        {
            transform.Translate(new Vector2(-0.04f, 0));
        }
        else
        {
            transform.Translate(new Vector2(0, 0));
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            ground = false;
        }
       
    }
}
