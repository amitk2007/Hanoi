using UnityEngine;
using System.Collections;

public class GuiButtonsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, Screen.width / 5f, Screen.height / 15f), "restart"))
			Application.LoadLevel ("game");		
		if (GUI.Button (new Rect (Screen.width-10- Screen.width / 5f, 10, Screen.width/5f, Screen.height/15f), "Menu"))
			Application.LoadLevel ("menu");		
	}
}
