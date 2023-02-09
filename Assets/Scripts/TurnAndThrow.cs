using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAndThrow : MonoBehaviour
{
    public GameObject Wheel;
    public float WheelSpeed;

    public GameObject Balls;
    public float BallSpeed;
    
    public GameObject ForScript;

    public GameObject NextLevelScene;

    public GameObject PauseMenu;
    

    private void Update()
    {
        Wheel.transform.Rotate(0,0, WheelSpeed);

        if (Balls.transform.childCount == 0 && !ForScript.GetComponent<Sticking>().IsDeath)
        {
            
            NextLevelScene.SetActive(true);
            Wheel.SetActive(false);
            Balls.SetActive(false);
            
            

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Balls.transform.childCount != 0)
            {
                Balls.transform.GetChild(0).GetComponent<Rigidbody2D>().AddForce(transform.up * BallSpeed);

                Invoke("MovingForward", 0.2f);

            }
        }

    }

    public void Shoot()
    {
        
        if (Balls.transform.childCount!=0)
        {
            Balls.transform.GetChild(0).GetComponent<Rigidbody2D>().AddForce(transform.up * BallSpeed);

            Invoke("MovingForward",0.2f);
            
        }

    }
    private void MovingForward()
    {
        for (int i = 0; i < Balls.transform.childCount; i++)
        {
            Balls.transform.GetChild(i).transform.position = new Vector2(Balls.transform.GetChild(i).transform.position.x,
                                                                        Balls.transform.GetChild(i).transform.position.y + 0.4f);
        }
    }
    public void OpenPauseMenu()
    {

        PauseMenu.SetActive(true);
        Wheel.SetActive(false);
        Balls.SetActive(false);
    }


}
