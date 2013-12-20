using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	private float gravity = -1f;
	private float speed = 15f;
	private float jumpHeight = .4f;
<<<<<<< HEAD
	public CharacterController controller;
	private float maxGravity = -.5f;
=======
	//public int count = 0;
	private float terminalVelocity = -.5f;
	public CharacterController controller;
>>>>>>> d2822524dbd4c48a0a8b7e48bc9c9637f46472d4
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal1")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump1")){
			if(controller.isGrounded){
				newPos.y = jumpHeight;
				print ("Jumping");
			}
		}
<<<<<<< HEAD

		if(newPos.y > maxGravity){
			newPos.y += gravity * Time.deltaTime;
		}

		controller.Move(newPos);
=======
		/*if(count > 1 && controller.isGrounded){
			count = 0;
		}*/
		if(newPos.y > terminalVelocity){
			newPos.y += gravity*Time.deltaTime;
		}

		controller.Move (newPos);
>>>>>>> d2822524dbd4c48a0a8b7e48bc9c9637f46472d4
	}
}