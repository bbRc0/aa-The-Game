using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticking : MonoBehaviour
{
    public Transform WheelTransform;
    public bool IsDeath;

    public GameObject Wheel;

    public GameObject Balls;

    public GameObject DeathScene;


    private void OnCollisionEnter2D(Collision2D place)
    {
        if (place.gameObject.tag == "Wheel")
        {

            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.parent = WheelTransform;
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            this.gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;



        }
        else if (place.gameObject.tag == "Littles")
        {
            DeathScene.SetActive(true);
            Wheel.SetActive(false);
            Balls.SetActive(false);


            IsDeath = true;
        }
    }


}
