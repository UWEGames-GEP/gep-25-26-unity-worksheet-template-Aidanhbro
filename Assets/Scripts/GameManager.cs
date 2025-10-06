using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public enum GameState { GAMEPLAY, ESCAPE, PAUSE, NULL };
    public GameState state = GameState.PAUSE;
    bool hasChangedState = false;
 
    void Start()
    {
        state = GameState.PAUSE;


    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.PAUSE;
                hasChangedState = true;
            }
            
        }
        else if (state == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.GAMEPLAY;
                hasChangedState = true;
            }
           
        }


       
    }

    private void LateUpdate()
    {
        if (hasChangedState)
        {
            hasChangedState = false;

            if (state == GameState.GAMEPLAY) 
            {
                Time.timeScale = 1.0f;
            }
            else if (state == GameState.PAUSE) 
            {
                Time.timeScale = 0.0f;
            }

        }



    }



}


