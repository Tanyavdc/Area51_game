using UnityEngine;
using System.Collections;

public class FP_Pickup : MonoBehaviour {

	public float range = 2.0f;
	
	
	//public AudioClip impact;
	//AudioSource audio;

	// Use this for initialization
	void Start () {
		//audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetMouseButton(0)) {
    
        
			Ray	ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, range) ) {
				
				Vector3 hitPoint = hitInfo.point;
				GameObject go = hitInfo.collider.gameObject;
				if ( go.tag == "Key"){
					go.tag = "Untagged";
					Debug.Log("got key!");
					Destroy(go);
				}
				
			}
		}
	}
}