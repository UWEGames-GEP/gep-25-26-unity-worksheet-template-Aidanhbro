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
    private void OnRemoveItem(InputValue value) 
    {
        Inventory inv = GetComponent<Inventory>();
        if (value.isPressed) 
        {
            // Debug.log("Remove Item");

           // ItemObject itemToRemove = inv.items[0];

            inv.removeItems();
           

            //  GetComponent<Inventory>().removeItems();


        }
    
    
    
    
    }
}
