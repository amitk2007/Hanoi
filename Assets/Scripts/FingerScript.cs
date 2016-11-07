using UnityEngine;
using System.Collections;

public class FingerScript : MonoBehaviour {

	bool touching = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount==1&&touching == false) {
			this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x,Input.touches[0].position.y,10));
			touching = true;
		}
		if (Input.touchCount == 0) {
			touching = false;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<Ring>()!=null) {
			other.gameObject.GetComponent<Ring>().OnMouseDown();
		}
	}
}
