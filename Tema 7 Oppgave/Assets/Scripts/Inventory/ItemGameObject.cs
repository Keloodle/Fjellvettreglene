using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGameObject : MonoBehaviour
{
	public Item itemStats;

	private void OnMouseDown()
	{

		if (InventoryScript.Instance.inventory.Count < 3 && !InventoryScript.Instance.backpack)
		{
			InventoryScript.Instance.AddItem(itemStats);

			this.gameObject.SetActive(false);
		}
		else if (InventoryScript.Instance.inventory.Count < 5 && InventoryScript.Instance.backpack)
		{
			InventoryScript.Instance.AddItem(itemStats);
			this.gameObject.SetActive(false);
		}

	}

}
[System.Serializable]
public class Item
{
	public string itemID;
	public string itemLabel;
	public Sprite sprite;
}
