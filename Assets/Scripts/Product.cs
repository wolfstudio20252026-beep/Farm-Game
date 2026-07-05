using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
    public GameObject shop;

    public int id;
    public string productName;
    public int price;

    public TMP_Text nameText, priceText;

    private void Start()
    {
        shop = GameObject.Find("shop");

        productName = shop.GetComponent<Shop>().productName[id];
        price = shop.GetComponent<Shop>().price[id];
    }
}
