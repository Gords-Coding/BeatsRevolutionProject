using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Ticked : MonoBehaviour {
	public Button TickBox1;
	public Button TickBox2;
	public Button TickBox3;
	public Sprite unticked;
	public Sprite ticked;
	private int counter = 0;

	// Use this for initialization
	void Start () {
		TickBox1 = GetComponent<Button>();
		TickBox2 = GetComponent<Button>();
		TickBox3 = GetComponent<Button>();

	}

	public void changeButton1 (){
		counter++;
		if (counter % 2 == 0) {
			TickBox1.image.overrideSprite = unticked;
		}
		else {
			TickBox1.image.overrideSprite = ticked;
		}
	}

	public void changeButton2 (){
		counter++;
		if (counter % 2 == 0) {
			TickBox2.image.overrideSprite = unticked;
		}
		else {
			TickBox2.image.overrideSprite = ticked;
		}
	}

	public void changeButton3 (){
		counter++;
		if (counter % 2 == 0) {
			TickBox3.image.overrideSprite = unticked;
		}
		else {
			TickBox3.image.overrideSprite = ticked;

		}
	}
}
