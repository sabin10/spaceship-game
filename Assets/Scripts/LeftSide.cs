using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSide : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Ship"){
			other.gameObject.transform.position = new Vector3(2.9f, other.gameObject.transform.position.y, other.gameObject.transform.position.z);

		}
	}
	
}
