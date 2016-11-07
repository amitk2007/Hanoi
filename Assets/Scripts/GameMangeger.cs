using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMangeger : MonoBehaviour
{
	public Canvas Win;
	public static GameObject[] Towers = new GameObject[3];
	int numberOfRing = MainMenu.RingsNumber;
	public static int numberOfRings;
	public static float RingHight = 0.5f;
    public GameObject ring, mot;
	static public float Hight;
    // Use this for initialization
    void Start()
    {
	
		//**********************
		numberOfRings = numberOfRing;
		//**********************
		Hight = TotalRingHight(numberOfRings);
        RingHight = TotalRingHight(numberOfRings) / (numberOfRings);//to change****
        //Creating the rings
        

		for (int i = -1; i< 2; i++) 
		{
			mot.transform.localScale = new Vector3( 0.2f, TotalRingHight(numberOfRings)+1f	,0.2f);
            Towers[i+1] = (GameObject)Instantiate(mot, new Vector3(i*((numberOfRings/2.5f)+1f), mot.transform.localScale.y, 0), mot.transform.localRotation);
		}
		for (int i = 0; i < numberOfRings; i++)
		{
			// Ring scale             = new Vector(        X radios           ,        hight          ,      Y radios             );
			ring.transform.localScale = new Vector3((numberOfRings - i) / 2.5f, RingHight, (numberOfRings - i) / 2.5f);
			//Create ring (ring properties, hight     ,         Rotation            );
			//Towers[1].GetComponent<Tower>().Rings.Push((GameObject)Instantiate(ring, new Vector3(0, i * (RingHight+0.2f) + 1f, 0),ring.transform.localRotation));
			Instantiate(ring, new Vector3(Towers[0].transform.position.x, i * (RingHight+0.2f) + 1f, 0),ring.transform.localRotation);
		}
	}

	// Update is called once per frame
    void Update()
	{
		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel("game");
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel("menu");
		}
		if (Towers [2].GetComponent<Tower> ().IsFull () && !Win.gameObject.activeSelf) {
			Win.gameObject.SetActive(true);
		}

	}

float TotalRingHight(int num)
{
    return ((int)(num / 5 + 1)) * 0.5f;
}

}
