using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int[] id;
    public string[] productName;
    public int[] price;

    public int numberOfProducts;

    public GameObject shopWindow;

    public GameObject[] products;

    public int pageNumber;

    public static bool beInShop;

    private void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            products[i].SetActive(false);
        }
        Refrech();
    }

    private void Update()
    {
        if(Product.isSowing == true)
        {
            CloseShop();
        }
    }

    public void OpenShop()
    {
        shopWindow.SetActive(true);
        beInShop = true;

        Refrech();
    }

    public void CloseShop()
    {
        shopWindow.SetActive(false);
        beInShop = false;
    }

    public void Refrech()
    {
        for (int i = 0; i < 12; i++)
        {
            products[i].SetActive(false);
        }

        if (pageNumber == 1)
        {
            for (int i = 0; i < 12; i++)
            {
                products[i].GetComponent<Product>().id = id[i];
                products[i].SetActive(true);
            }
        }
    }

    public void Left()
    {

    }

    public void Right()
    {

    }
}
