using UnityEngine;
using System.Collections;

public class BULLET_ThermalDetonator : MonoBehaviour {
	
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		
		if(collision.gameObject.tag == "Enemy") {
			collision.gameObject.tag = "Untagged";
			Destroy(collision.gameObject);
			Debug.Log("dead");
		}
	}
	
		void OnCollisionEnter2D(Collision2D collision) {
		
		if(collision.gameObject.tag == "Enemy") {
			collision.gameObject.tag = "Untagged";
			Destroy(collision.gameObject);
			Debug.Log("dead");
		}
	}
	
	
	void Explode() {
		
		Destroy(gameObject);
	}
}
