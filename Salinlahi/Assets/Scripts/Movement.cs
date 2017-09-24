using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public GameObject box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveUp () {
		box.GetComponent<Transform> ().position += Vector3.up;
	}
	public void MoveDown() {
		box.GetComponent<Transform> ().position += Vector3.down;
	}
	public void MoveLeft() {
		box.GetComponent<Transform> ().position += Vector3.left;
	}
	public void MoveRight() {
		box.GetComponent<Transform> ().position += Vector3.right;
	}
}
