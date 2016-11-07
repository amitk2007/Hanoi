using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tower : MonoBehaviour {

	public Stack<GameObject> Rings = new Stack<GameObject>();
	public GameObject Top;
	int wo=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Rings.Count == 0) {
			Top = null;
		} else {
			Top = Rings.Peek();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject!=null&&wo==1)
			Rings.Push (other.gameObject);
		wo = 1 - wo;
	}
	void OnTriggerExit(Collider other)
	{
		//Destroy(other.gameObject);
		if(wo==1)
			Rings.Pop();
		wo = -wo;
	}

	void OnMouseDown() 
	{
		if (Top == null) {
			MoveRing ();
		}
		else if (Ring.AirRing!=null && Ring.AirRing.transform.localScale.x<Top.transform.localScale.x) {
			MoveRing ();
		}

	}

	void MoveRing()
	{
		if (Ring.AirRing == null)
			return;
		RingMovment ();
		Ring.AirRing.transform.GetComponent<Rigidbody> ().useGravity = true;
		Ring.AirRing = null;
		Ring.isPressed = false;
	}

	void RingMovment()
	{
		float move = this.transform.localPosition.x;
		Ring.AirRing.transform.position = new Vector3(move,Ring.AirRing.transform.position.y,Ring.AirRing.transform.position.z);
	}

	public bool IsFull()
	{

		if (GameMangeger.numberOfRings == Rings.Count) {
			return true;
		}
		return false;
	}
	public bool IsEmpty()
	{
		return Top == null;
	}
}
