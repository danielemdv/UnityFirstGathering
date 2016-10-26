using UnityEngine;
using System.Collections;

public class alienBehaviour : MonoBehaviour {

	public float timeWaitToMove = 2f;
	public float moveDistance = 0.05f;

	private int nextDirectionIndex = 0;
	private Vector2 nextDirection;


	private float nextMoveTime;

	// Use this for initialization
	void Start () {
		nextMoveTime = Time.time + timeWaitToMove;
		CalcNextDirection ();
	}
	
	// Update is called once per frame
	void Update () {
			
		
	}

	void FixedUpdate(){
		Move();
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "bullet") {
			Destroy(other.gameObject);
			Destroy (gameObject);
		}
	
	}

	void Move(){
		if (Time.time >= nextMoveTime) {
			transform.Translate (nextDirection * moveDistance);
			CalcNextDirection ();
			nextMoveTime = Time.time + timeWaitToMove;
		}

	}

	//WIll set nextDirection to the vector that corresponds to the following direction the alien will move considering the previous value.
	void CalcNextDirection(){
		if(nextDirectionIndex == 0){
			nextDirection = Vector2.down;
		}else if(nextDirectionIndex == 1){
			nextDirection = Vector2.left;
		}else if(nextDirectionIndex == 2){
			nextDirection = Vector2.down;
		}else if(nextDirectionIndex == 3){
			nextDirection = Vector2.right;
		}

		nextDirectionIndex++;

		if (nextDirectionIndex == 4) {
			nextDirectionIndex = 0;
		}

	}

}
