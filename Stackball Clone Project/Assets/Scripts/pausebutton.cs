using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausebutton : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    public bool Paused=false;
    public void pausecanvas()
    {
        if (Paused)
        {
            Time.timeScale = 1;
            Paused = false;
            
        }
        else
        {
            Time.timeScale = 0;
            Paused = true;
            pause.gameObject.SetActive(true);

        }
    }
}
