using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controllers : MonoBehaviour
{
    public float movespeed;
    public GameObject ball;
    public bool grounded;
    int rastgelesayi=2;
    float aralik = -2.43f;
    public GameObject solblock, sagblock;
    public Slider slider, jewelslider;
    public TMP_Text scoreText, jewelText;
    int score;
    public GameObject pause;
    public bool Paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touchmovement();
    }

    void Touchmovement()
    {
        if (Input.GetMouseButtonDown(0)&&grounded==true)
        {
            Vector3 Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Mousepos.y>-10)
            {
                transform.Translate(0, movespeed*Time.deltaTime, 0);
                grounded = false;
            }
            
        }
      
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
        if (collision.gameObject.tag=="block")
        {
            if (score <= 9 && grounded==true)
            {
                slider.value++;
                jewelslider.value++;
                score++;
                scoreText.SetText(score.ToString());
                jewelText.SetText(score.ToString());
                
                aralik = aralik + 0.51f;
                
                if (rastgelesayi == 1)
                {
                    Instantiate(solblock, new Vector2(-3.4f, aralik), Quaternion.identity);
                    rastgelesayi++;
                }
                else if (rastgelesayi == 2)
                {
                    Instantiate(sagblock, new Vector2(3.4f, aralik), Quaternion.identity);
                    rastgelesayi--;
                }
            }
            if (score==10)
            {
                Time.timeScale = 0;
                Paused = true;
                pause.gameObject.SetActive(true);
                solblock.transform.Translate(new Vector2(0, 0));
                sagblock.transform.Translate(new Vector2(0, 0));
            }
        }
       
    }
}
