using UnityEngine;
using System.Collections;

public class Doge : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	private float gravity = -1f;
	private float speed = 15f;
	private float jumpHeight = .4f;
	private float maxGravity = -.4f;
	public CharacterController controller;
		
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
		if(newPos.y > maxGravity){
			newPos.y += gravity * Time.deltaTime;
		}
		controller.Move(newPos);
	}	
}