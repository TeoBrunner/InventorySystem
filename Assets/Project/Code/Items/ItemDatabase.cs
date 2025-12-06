using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Database", menuName = "Inventory/Item Database")]
public class ItemDatabase : ScriptableObject
{
    [SerializeField] private List<ItemData> items = new();

    public ItemData GetItem(string id) 
    {   
        if(items.Count == 0)
        {
            Debug.LogError("Item Database is empty!");
            return null;
        }

        ItemData item = items.FirstOrDefault(i => i.ItemID == id);
        if (item == null)
        {
            return items[0];
        }
        else
        {
            return item;
        }
    }
}
