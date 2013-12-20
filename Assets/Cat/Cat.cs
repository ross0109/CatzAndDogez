using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	private float gravity = -1f;
	private float speed = 15f;
	private float jumpHeight = .4f;
	private float maxGravity = -.5f;
	public CharacterController controller;

	private int count = 0;

	void Start () {
		controller = GetComponent<CharacterController>();
	}	
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal1")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump1")){
			if(controller.isGrounded){
				newPos.y = jumpHeight;
				print ("Jumping");
				++count;
			}
			/*if(Input.GetButtonDown("Jump1") && count == 1){
				newPos.y = jumpHeight;
				print ("Jumping");
				++count;
			}*/

		}
		if(controller.isGrounded){
			count = 0;
		}
		if(newPos.y > maxGravity){
			newPos.y += gravity * Time.deltaTime;
		}
		controller.Move(newPos);
	}
}