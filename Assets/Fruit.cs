﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
	public string color;

	public Fruit()
	{
		color = "orange";
		Debug.Log ("1st Fruit Constructor Called");
	}

	public Fruit(string newColor)
	{
		color = newColor;
		Debug.Log ("2nd Fruit Constructor Called");
	}

	public void chop()
	{
		Debug.Log ("The" + color + " fruit has been chopped");
	}

	public void sayHello()
	{
		Debug.Log ("Hola soy una fruta");
	}

}
