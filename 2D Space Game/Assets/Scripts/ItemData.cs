using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;

public class ItemData : MonoBehaviour
{
	private List<Item> database = new List<Item>();
	private JsonData itemData;

	void Start()
	{
		itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
		ConstructItemDatabase();

		Debug.Log("Title=" + database[1].Title);
	}

	/* public Item FetchItemByID()
        {
            for (int i = 0; i < database.Count; i++)
            {
                if(database[i].id == )
                return new Item();
            }
            return null;
               
        }*/
	void ConstructItemDatabase()
	{
		for (int i = 0; i < itemData.Count; i++)
		{
			database.Add(new Item((int)itemData[i]["id"],(string)itemData[i]["title"],(int)itemData[i]["value"]));
		}
	}

}



public class Item
{
	public int Id { get; set; }
	public string Title { get; set; }
	public int Value { get; set; }

	public Item(int id, string title, int value)
	{
		this.Id = id;
		this.Title = title;
		this.Value = value;
	}


}