using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningForLevel4 : MonoBehaviour
{
    public GameObject Wheel;

    public GameObject Balls;


    private void Update()
    {
        if (Balls.transform.childCount < 6)
        {
            Wheel.transform.Rotate(0, 0, -2 * FindObjectOfType<TurnAndThrow>().WheelSpeed);
        }

        if (Balls.transform.childCount < 3)
        {
            Wheel.transform.Rotate(0, 0,  3 * FindObjectOfType<TurnAndThrow>().WheelSpeed);
        }
       
       
        
    }


}
