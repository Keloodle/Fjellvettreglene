using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
	private static InventoryScript instance;
	public static InventoryScript Instance => instance;

	public bool backpack = false;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(this);
		}
	}

	public void AddItem(Item item)
	{
		inventory.Add(item);
		FindObjectOfType<FillInventory>().AddItem(item);
	}

	public List<Item> inventory = new List<Item>();
}
