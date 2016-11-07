using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MainMenu : MonoBehaviour {


	public Text Error;
	public InputField NumInputField;
	public static int RingsNumber = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ButtonStart()
	{
		try{
			RingsNumber = int.Parse(NumInputField.text);
			if (RingsNumber <1||RingsNumber>10) {
				throw new Exception();
			}
		}
		catch(Exception e)
		{
			Error.text="Error, number of rings have to be a number betwin 1-10.";
			return;
		}
		Application.LoadLevel ("game");
	}
}
