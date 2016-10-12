using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Color defaultColor;
	public Color selectedColor;
	public Material mat;

	//SUPER TRAMPA QUE NO SE DEBERIA DE HACER LOLOL
	public playerBehaviour player;



	// Use this for initialization
	void Start () {
		mat = gameObject.GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTouchDown(){
		mat.SetColor("Emission", selectedColor);
		player.SendMessage ("fire", SendMessageOptions.DontRequireReceiver);
	
	}

	void OnTouchUp(){
		mat.color = defaultColor;

	}

	void OnTouchStay(){
		mat.color = selectedColor;


	}

	void OnTouchExit(){
		mat.color = defaultColor;

	}
}
