using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningForLevel3 : MonoBehaviour
{
    public GameObject Wheel;

    public GameObject Balls;


    private void Update()
    {
        if (Balls.transform.childCount < 5)
        {
            Wheel.transform.Rotate(0, 0, -2*FindObjectOfType<TurnAndThrow>().WheelSpeed);
        }
    }

    
}
