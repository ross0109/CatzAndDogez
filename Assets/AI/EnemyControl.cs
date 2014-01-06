using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
	public Vector2 newPos = new Vector2(0f, 0f);
	public Vector2 startPos = new Vector2(0f, 0f);
	public int count = 0;
	private float speed = 4f;
	private float distanceTravelled = 0f;
	private CharacterController controller;

	void Start () {

	}
	void Update () {
		newPos.x += speed;

		controller.Move(newPos);
	}
}
