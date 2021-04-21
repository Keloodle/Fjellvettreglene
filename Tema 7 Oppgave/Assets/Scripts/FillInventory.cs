using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInventory : MonoBehaviour
{
    public GameObject imagePrefab;

    public void AddItem(Item item)
	{
        var image = Instantiate(imagePrefab, transform).GetComponent<Image>();
        image.sprite = item.sprite;
        image.GetComponent<ItemImage>().item = item;
	}
    void Start()
    {
		foreach (var item in InventoryScript.Instance.inventory)
		{
            AddItem(item);
		}
    }
}
