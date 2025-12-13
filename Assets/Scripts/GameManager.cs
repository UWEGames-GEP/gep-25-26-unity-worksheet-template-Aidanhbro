using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameState state = GameState.PAUSE;
    bool hasChangedState = false;
    public GameObject inventoryUI;
    
    void Start()
    {
        state = GameState.GAMEPLAY;
        inventoryUI.SetActive(false);

    }

    public void Pausing()
    {
        if (state == GameState.GAMEPLAY)
        {
            state = GameState.PAUSE;
            hasChangedState = true;

        }
        else if (state == GameState.PAUSE)
        {

            state = GameState.GAMEPLAY;
            hasChangedState = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }





    private void LateUpdate()
    {
        if (hasChangedState)
        {
            hasChangedState = false;

            if (state == GameState.GAMEPLAY)
            {
                Time.timeScale = 1.0f;



                inventoryUI.SetActive(false);


                Cursor.lockState = CursorLockMode.Locked;
            }
            else if (state == GameState.PAUSE)
            {
                Time.timeScale = 0.0f;


                inventoryUI.SetActive(true);

                
                Cursor.lockState = CursorLockMode.None;

            }

        }



    } 



}
public enum GameState { GAMEPLAY, ESCAPE, PAUSE, NULL };

