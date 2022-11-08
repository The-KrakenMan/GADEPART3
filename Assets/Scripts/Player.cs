using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody rbCar;
    public float Speed;
    public float TurnSpeed;
    public int WaypointCount = 0;
    public int Lapcounter = 1;
    public Text LapOut;
    public GameObject WinScreen;



    // Start is called before the first frame update
    void Start()
    {
        LapOut.text = Lapcounter.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rbCar.AddRelativeForce(Vector3.forward*Speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rbCar.AddRelativeForce(Vector3.back*(Speed/2));
        }


        if (Input.GetKey(KeyCode.A))
        {
            rbCar.AddTorque(-Vector3.up *TurnSpeed);
        }


        if (Input.GetKey(KeyCode.D))
        {
            rbCar.AddTorque(Vector3.up *TurnSpeed);
        }


    }

    public void Lap()
    {
        if (Lapcounter < 4)
        {
            Lapcounter++;
            LapOut.text = Lapcounter.ToString();
        }
        else
        {
            Win();
        }
        
    }

    public void Win()
    {
        WinScreen.SetActive(true);
    }

}
