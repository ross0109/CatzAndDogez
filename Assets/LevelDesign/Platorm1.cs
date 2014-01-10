using UnityEngine;
using System.Collections;

public class Platorm1 : MovePlatform {

	void Start () {
		controller = GetComponent<CharacterController>();
		setDisplacement(.05f);
		setSpeed(.01f);
	}

	void Update () {
		movement();
	}
}
