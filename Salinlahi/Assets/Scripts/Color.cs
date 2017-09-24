using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {

	public GameObject box;
	public Material materialRed; 
	public Material materialBlue;
	public Material materialGreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeColorToBlue () {
		box.GetComponent<MeshRenderer> ().material = materialBlue;
	}
	public void ChangeColorToRed () {
		box.GetComponent<MeshRenderer> ().material = materialRed;
	}
	public void ChangeColorToGreen () {
		box.GetComponent<MeshRenderer> ().material = materialGreen;
	}

}
