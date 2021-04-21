using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInventory : MonoBehaviour
{
    public GameObject imagePrefab;
	public GridLayoutGroup imageGrid;

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



	private void RefreshInventory()
	{
		for (int i = 0; i < imageGrid.transform.childCount; i++)
		{
			Destroy(imageGrid.transform.GetChild(i).gameObject);
		}
		foreach (var item in InventoryScript.Instance.inventory)
		{
			AddItem(item);
		}
	}
}
