using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*if(Input.GetAxis("X axis")){

		}*/

		if(Input.GetButtonDown("360_AButton")){

			transform.Translate( Vector3.back);
			Debug.Log("Input Button A");

		}

		
		/*if(Input.GetButton("joystick button 1")){
			
		}

		
		if(Input.GetButton("joystick button 2")){
			
		}*/

		// lancer un raycast ou faire avec collision pour savoir dans quelle zone le joueur se trouve et changer sa forme en fonction
	
	}
}
