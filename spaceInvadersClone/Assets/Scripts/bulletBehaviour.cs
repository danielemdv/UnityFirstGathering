using UnityEngine;
using System.Collections;

public class bulletBehaviour : MonoBehaviour {


	public float speed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > Camera.main.orthographicSize) {
			Destroy (gameObject);
		}
	}

	void FixedUpdate(){
		transform.Translate (Vector2.up * speed * Time.fixedDeltaTime);
	
	}
}
