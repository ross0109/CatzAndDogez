using UnityEngine;
using System.Collections;

public class Doge : MonoBehaviour {
	public Vector2 newPos = new Vector2 (0f, 0f);
	private float gravity = -1f;
	private float speed = 15f;
	private float jumpHeight = .4f;
	private float maxGravity = -.4f;
	private float height = 0f;
	private float checkHeight;
	public CharacterController controller;
		
	void Start () {
		controller = GetComponent<CharacterController>();
		/*GameManager.gameStarter += gameStart;
		GameManager.gameEnder += gameEnd;*/
	}
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal2")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump2")){
			if(controller.isGrounded){
				newPos.y = jumpHeight;
				//print ("Jumping");
			}

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
	public void gameStart() {
		enabled = true;
	}
	public void gameEnd() {
		enabled = false;
	}
}