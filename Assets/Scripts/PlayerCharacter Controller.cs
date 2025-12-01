using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : ThirdPersonController
{

    private void OnPause(InputValue value) 
    {
         if (value.isPressed) 
        {
            Debug.Log("Pause Game"); 
        }  
    
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
