﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class Person : Mthing {

	public ArrayList inventory;
	public GameObject display;
	public float spokentime;

	public Person(string name, int x, int y)
		: base(name,x,y)
	{
		//Inventory
		this.inventory = inventory;
		//GUI Text 

		this.display = GameObject.Find("/World/PlayerGroup/TextDisplay");
		this.display.SetActive (false);
		this.spokentime = 0.0f;
	}
	
	public override bool is_person() {return true;}

	public void add_to_inventory(Wobject item) {
		this.inventory.Add(item);
	}

	public void remove_from_inventory(Wobject item) {
		foreach(Wobject thing in this.inventory)
		{
			if (thing.get_name() == item.get_name()) {
				this.inventory.Remove(thing);
			}
		}
	}

	public void speak(string sentence) {
		this.display.guiText.text = sentence;	
		this.spokentime = Time.time;
	}
}