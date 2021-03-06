﻿using UnityEngine;
using System.Collections;

public class FindWeaponQuest : QuestState {

	// Use this for initialization
	public override void OnStart () {
	
	}
	
	// Update is called once per frame
	public override void OnUpdate () {

		//TODO: Add an event for item pickup instead of scanning.

		if ( Complete == false )
		{
			var equipObj = GameObject.FindGameObjectWithTag("Equipment");
			var inventoryObj = GameObject.FindGameObjectWithTag("Inventory");

			var equip = equipObj.GetComponent<Inventory>();
			var inv = inventoryObj.GetComponent<Inventory>();

			if ( equip.GetItemSlotWithItem("Gun_Pulse") != null ){
				this.Complete = true;
				NotifyComplete();
			}
			if ( inv.GetItemSlotWithItem("Gun_Pulse") != null ){
				this.Complete = true;
				NotifyComplete();
			}
		}

	}
}
