using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {

	float radius;
	public static bool isPressed = false;
	public static GameObject AirRing;
	// Use this for initialization
	void Start () {
		radius = transform.localScale.x;
	}

	public void OnMouseDown() {
		if (isPressed) {
			unpress();
			isPressed = false;
		}
		if (!isPressed) {
			if (IsUp()) {
			pressed ();
			isPressed = true;
			}
		}
	}

	void pressed()
	{

		this.transform.GetComponent<Rigidbody> ().useGravity = false;
		transform.position = new Vector3(transform.position.x,(GameMangeger.Hight+1f)*2f,transform.position.z);
		AirRing = this.gameObject;
	}
	void unpress()
	{
		AirRing.transform.GetComponent<Rigidbody> ().useGravity = true;
	}
	bool IsUp()
	{
		foreach (GameObject tower in GameMangeger.Towers) {
			if (tower.GetComponent<Tower> ().Top != null) {
				if (tower.GetComponent<Tower> ().Top == this.gameObject)
					return true;
			}
		}
		return false;
	}
}
