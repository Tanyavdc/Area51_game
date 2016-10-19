using UnityEngine;
using System.Collections;

public class FP_Shooting : MonoBehaviour {
	
	public GameObject bullet_prefab;
	public AudioClip impact;
	AudioSource audio;
	
	float bulletImpulse = 20f;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButtonDown("Fire1") ) {
			audio.PlayOneShot(impact,0.7F);
			Camera cam = Camera.main;
			GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
			thebullet.GetComponent<Rigidbody>().AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
		}
	}
}
