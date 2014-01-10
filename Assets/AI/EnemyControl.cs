using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
	public Vector2 newPos = new Vector2(0f, 0f);
	public Vector2 startPos = new Vector2(0f, 0f);
	private float gravity = -1f;
	private float maxGravity = -.4f;
	private float speed = .01f;
	private float displacement = .1f;
	private Vector2 pastPos;
	private bool goingRight = true;

	public CharacterController controller;

	public float getDisplacement(){
		return displacement;
	}
	public void setDisplacement(float d){
		displacement = d;
	}
	public float getSpeed(){
		return speed;
	}
	public void setSpeed(float newS){
		speed = newS;
	}
	public void Start () {
		controller = GetComponent<CharacterController>();
		/*GameManager.gameStarter += gameStarter;
		GameManager.gameEnder += gameEnder;*/
	}
	void Update () {

	}
	public void movement(){
		if(pastPos != transform.localPosition){
			pastPos = transform.localPosition;
		}
		if(goingRight){
			newPos.x += speed;
		}
		else if(!goingRight){
			newPos.x -= speed;
		}
		if(Mathf.Abs(newPos.x) >= displacement && goingRight){
			goingRight = false;
		}
		else if(Mathf.Abs(newPos.x) >= displacement && !goingRight){
			goingRight = true;
		}
		if(newPos.y > maxGravity){
			newPos.y += gravity * Time.deltaTime;
		}
		//scenario if the pastPos equals the localPos, then the enemy is not moving. only preform the movement statements if it is moving
		checkAnimal();
		controller.Move(newPos);
	}
	public void checkAnimal(){

	}

}
