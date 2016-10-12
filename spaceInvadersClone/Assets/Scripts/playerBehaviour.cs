using UnityEngine;
using System.Collections;

public class playerBehaviour : MonoBehaviour {


	public float speed = 7f;
	public float fireWaitTime = 0.4f;



	public GameObject bullet;


	private Transform bp;

	//No deberia de hacer esto
	private float dir = 0;


	private float nextFireTime;
	// Use this for initialization
	void Start () {
		nextFireTime = Time.time;
		bp = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () {

		//float dir = Input.GetAxisRaw ("Horizontal");


		transform.Translate (Vector2.right * dir * speed * Time.deltaTime);

		if (transform.position.x + 0.13f > Camera.main.orthographicSize * Camera.main.aspect) {

			transform.position = new Vector3 ((Camera.main.orthographicSize * Camera.main.aspect) - 0.13f, transform.position.y, transform.position.z);
		}

		if(transform.position.x - 0.13f < -Camera.main.orthographicSize * Camera.main.aspect){

			transform.position = new Vector3 (-(Camera.main.orthographicSize * Camera.main.aspect) + 0.13f, transform.position.y, transform.position.z);
				
		}

		if(Input.GetButtonDown("Fire1") == true){
			//Call bullet firing function
			fire();

		}
	}

	void setDirectionRight(){
		dir = 1;
		
	}

	void setDirectionLeft(){
		dir = -1;

	}

	void setDirectionZero(){
		dir = 0;

	}

	void fire(){

		if (Time.time >= nextFireTime) {
			//Instance the bullet
			Instantiate(bullet, new Vector3(bp.position.x, bp.position.y, 0), Quaternion.identity);
			nextFireTime = Time.time + fireWaitTime;
		}
		
	}
}
