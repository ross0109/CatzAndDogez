using UnityEngine;
using System.Collections;

public class Doge : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	public float gravity = 1f;
	public float speed = 3f;
	public float jumpHeight = .25f;
	private CharacterController controller;
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal2")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump2")){
			if(controller.isGrounded){
				newPos.y = jumpHeight;
				print ("Jumping");
			}
		}

		newPos.y += gravity*Time.deltaTime;
		controller.Move (newPos);
	}	
}