using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if(Input.GetButtonDown("Return")){
			Application.LoadLevel(1);
		}
	}
}
