﻿using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	private MenuItem [] MenuItems;
	private int selection = -1;

	// Use this for initialization
	void Start () {

		Screen.lockCursor = false;
		Screen.showCursor = true;

		this.MenuItems = GetComponentsInChildren<MenuItem>();
		for ( int i = 0; i < this.MenuItems.Length; i++ )
		{
			this.MenuItems[i].menu = this;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKeyUp(KeyCode.UpArrow) ) 
		{
			selection--;
			if ( selection < 0) selection = MenuItems.Length -1;
		}

		if ( Input.GetKeyUp(KeyCode.DownArrow) ) 
		{
			selection++;
			if ( selection > MenuItems.Length - 1) selection = 0;
		}

		if ( Input.GetButtonUp("Fire1") || Input.GetKeyUp(KeyCode.Return ) )
		{
			if ( selection != -1 )
			{
				MenuItems[selection].DoActions();
			}
		}

		for ( int i = 0; i < this.MenuItems.Length; i++ )
		{
			this.MenuItems[i].guiText.color = Color.white;
			if ( selection == i )
			{
				this.MenuItems[i].guiText.color = Color.yellow;
			}
		}


	}

	public void SelectGui(MenuItem item)
	{
		for ( int i = 0; i < this.MenuItems.Length; i++ )
		{
			if ( MenuItems[i] == item ) {
				selection = i;
				break;
			}
		}

	}

}
