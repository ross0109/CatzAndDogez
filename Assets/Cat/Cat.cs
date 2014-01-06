using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	private float gravity = -1f;
	private float speed = 15f;
	private float jumpHeight = .4f;
	private float maxGravity = -.4f;
	public CharacterController controller;
	private float height = 0f;
	private float checkHeight;
	private int count = 0;

	void Start () {
		controller = GetComponent<CharacterController>();
	}	
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal1")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump1")){
			Jump ();
		}
		if(controller.isGrounded){
			count = 0;
		}

		if(newPos.y > maxGravity){
			newPos.y += gravity * Time.deltaTime;
		}
		controller.Move(newPos);
		if(!controller.isGrounded){
			height = transform.localPosition.y;
			if(height == checkHeight){
				newPos.y = 0f;
				controller.Move(newPos);
			}
			checkHeight = height;
		}

	}

	void Jump(){
		if(count <= 1){
			newPos.y = jumpHeight;
			print ("Jumping");
			++count;
		}
	}
	






}