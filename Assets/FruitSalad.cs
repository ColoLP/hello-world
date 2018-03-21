using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour 
{
	
	void Start()
	{
		Debug.Log ("Creando una fruta");
		Fruit miFruta = new Fruit ();
		Debug.Log ("Creando una manzana");
		Apple manzana = new Apple ();

		miFruta.sayHello ();
		miFruta.chop ();


		manzana.sayHello ();
		manzana.chop ();

		Debug.Log ("Creando otra fruta");
		Fruit frutaNueva = new Fruit ("Amarilla");
		Debug.Log ("Creando otra manzana");
		Apple manzanaVerde = new Apple ("Verde");


		frutaNueva.chop ();
		frutaNueva.sayHello ();

		manzanaVerde.sayHello ();
		manzanaVerde.chop ();

	}
}
