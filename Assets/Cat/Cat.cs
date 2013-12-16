using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	public float gravity = -1f;
	public float speed = 5f;
	public float jumpHeight = .3f;
	public int count = 0;
	public float terminalVelocity = -5f;
	private CharacterController controller;
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal1")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump1")){
			if(controller.isGrounded || count == 1){
				newPos.y = jumpHeight;
				print ("Jumping");
			}
			count++;
		}
		if(count > 1 && controller.isGrounded){
			count = 0;
		}
		newPos.y += gravity*Time.deltaTime;
		controller.Move (newPos);
	}
}