using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerCharacterController : ThirdPersonController
{

    private void OnPause(InputValue value) 
    {
         if (value.isPressed) 
        {
            //Debug.Log("Pause Game");
            GetComponent<GameManager>().Pausing();
        }  


    
    }  
}
