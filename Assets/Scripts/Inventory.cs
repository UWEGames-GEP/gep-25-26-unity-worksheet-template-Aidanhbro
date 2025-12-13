using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public List<ItemObject> items = new List<ItemObject>();
     GameManager gameManager;
     Transform worldItemsTransform;
   
   public void AddItems(ItemObject item) 
    {

       // AddItems(collisionItem.items);
        items.Add(item);
       
       
    }

    

   public void removeItems(ItemObject item) 
    {
    
            
          //  ItemObject item = items[0];
            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;
            
            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;

            Quaternion newRotation = currentRotation * Quaternion.Euler(0,0,180);
                GameObject newItem = Instantiate(item.gameObject,newPosition,newRotation,worldItemsTransform);
          newItem.SetActive(true);

            items.Remove(item);
            Destroy(item.gameObject);
            //items.RemoveAt(0); 


     
    }
    public void removeItems()
    {
        if (gameManager.state == GameState.GAMEPLAY && items.Count > 0) 
        {

            ItemObject item = items[0];
            removeItems(item);
        }
       

    }
    public void removeItems(int i) 
    {
        if (i < items.Count) 
        {
        removeItems(items[i]);
        }
    
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //AddItems("health");
        //Console.WriteLine(items[1]);
        gameManager = FindAnyObjectByType<GameManager>();
       Transform worldItemsTransform = GameObject.Find("WorldItems").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //gameManager.state==GameManager.GameState.GAMEPLAY


        //if (gameManager.state == GameState.GAMEPLAY)
        //{
        //    if (Input.GetKeyDown(KeyCode.Alpha1))
        //    {
        //        AddItems("Generic Item");
        //    }
        //    if (Input.GetKeyDown(KeyCode.Alpha2))
        //    {
        //        removeItems("Generic Item");
        //    }
        //}


    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();
        if (collisionItem != null) 
        {


            items.Add(collisionItem);
            collisionItem.gameObject.SetActive(false);



        //    Debug.Log("testing");
        //    AddItems(collisionItem);
        //    Console.WriteLine("Hit");
        //  //  Destroy(collisionItem.gameObject);
        ////  collisionItem.gameObject.SetActive(false);
        //    hit.gameObject.SetActive(false);
          
        }

    }
}
