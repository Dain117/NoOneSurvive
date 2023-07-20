using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickUp : MonoBehaviour
{
    
    public Image itemImage;
    public Image usedImage;
    public Image HGImage;
    public Item item;

    private void Start()
    {
        itemImage = GameObject.Find("ItemImg").GetComponent<Healing>().GetComponent<Image>();
        usedImage = GameObject.Find("UsedImg").GetComponent<Meat>().GetComponent<Image>();
        HGImage = GameObject.Find("HGImg").GetComponent<Meat>().GetComponent<Image>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AttackPoint")
        {

            if (gameObject.GetComponent<ItemPickUp>().item.itemImage.name == "equip_icon_potion_red_2")
            {
                itemImage.sprite = gameObject.GetComponent<ItemPickUp>().item.itemImage;
                Destroy(gameObject);
            }
            else if (gameObject.GetComponent<ItemPickUp>().item.itemImage.name == "icon_food_meat")
            {
                HGImage.sprite = gameObject.GetComponent<ItemPickUp>().item.itemImage;
                Destroy(gameObject);
            }
        }
    }

}
