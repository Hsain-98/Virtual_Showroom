using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class InputManager : MonoBehaviour
{

    private Controller controller;

    public float vertical;
    public float horizontal;
    public float xValue, yValue;

    public static bool pause;

    private void Start()
    {
        pauseGame();
        controller = GetComponent<Controller>();
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) pauseGame();
        if (pause)
        {
            vertical = 0;
            horizontal = 0;
            xValue = 0;
            yValue = 0;
        }
        else
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
            xValue = CrossPlatformInputManager.GetAxis("Mouse Y");
            yValue = CrossPlatformInputManager.GetAxis("Mouse X");
            //if (Input.GetKeyDown(KeyCode.Space)) controller.jump();
        }
    }

    public void pauseGame()
    {
        if (pause)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            //Cursor.visible = false;
            pause = false;
            return;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            pause = true;
        }

        //pause=!pause;
    }

}

