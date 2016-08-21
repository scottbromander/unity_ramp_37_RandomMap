using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private MapMovementController moveController;


	// Use this for initialization
	void Start () {
		moveController = GetComponent<MapMovementController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("Pressed Up!");
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("Pressed Right!");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("Pressed Down!");
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("Pressed Left!");
		}
	}
}
