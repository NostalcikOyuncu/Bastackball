using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Paused = false;
    public GameObject pause;
    public void startgame()
    {
        Time.timeScale = 1;
        pause.gameObject.SetActive(false);
    }
    public void restartgame(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
