using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	
	// 1 is visible 0 is invisible 
	public int state = 0; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int choice = Random.Range(0,500);
		// invisible 
		if (state == 0) {
			if (choice % 100 == 0){
				state = 1;
			}
		}
		// visible 
		if (state == 1) {
			if (choice % 11 == 0){
				state = 0;
			}
		}

		// invisible 
		if (state == 0) {
			GetComponent<Renderer>().enabled=false;
			GetComponent<Collider>().enabled=false;
			this.gameObject.tag = "Untagged";
		}
		else {
			this.gameObject.tag = "Enemy";
			GetComponent<Renderer>().enabled=true;
			GetComponent<Collider>().enabled=true;
		}
	}
}
