using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
    public GameObject shop;

    public GameObject goldSystem;

    public int id;
    public string productName;
    public int price;

    public TMP_Text nameText, priceText;

    public static bool placeSeels;
    public static int whichSpeed;

    public static bool isSowing;
    private void Start()
    {
        shop = GameObject.Find("Shop");

        //productName = shop.GetComponent<Shop>().productName[id];
        //price = shop.GetComponent<Shop>().price[id];

        goldSystem = GameObject.Find("GoldSystem");
    }

    private void Update()
    {
        nameText.text = "" + productName;
        priceText.text = price + " $";

        productName = shop.GetComponent<Shop>().productName[id];
        price = shop.GetComponent<Shop>().price[id];
    }

    public void Buy()
    {
        if (goldSystem.GetComponent<GoldSystem>().gold >= price)
        {
            placeSeels = true;
            whichSpeed = id;
            goldSystem.GetComponent<GoldSystem>().gold -= price;

            isSowing = true;
        }
    }
}
