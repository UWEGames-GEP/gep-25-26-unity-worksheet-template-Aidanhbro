using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventoryUIButton : MonoBehaviour
{
  
    public TMP_Text text;
    public TMP_Text itemButtonAmount;
    public Image thumbnailImage;


    public void SetButton(ItemObject item) 
    {

        //text.text = item.;WorldItems
      
        text.text = item.itemName;
        itemButtonAmount.text = item.itemAmount.ToString();
        thumbnailImage.sprite = item.thumbnail;
    }

   
    //
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
