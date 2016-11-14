using UnityEngine;
using System.Collections;

public class MyUI : MonoBehaviour {
	public Material body;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void ButtondownRed(){
		body.color = Color.red;
	}
	public void Buttondownblue(){
		body.color = Color.blue;
	}
	public void Buttondowngreen(){
		body.color = Color.green;
	}
	public void Buttondownwhite(){
		body.color = Color.white;
	}
	public void Buttondownblack(){
		body.color = Color.black;
	}
}
