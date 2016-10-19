using UnityEngine;
using System.Collections;

public class LifeSpan : MonoBehaviour {
	
	 public static int remaining = 20;
	 string msg; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PointCounter.finish != true){
			if (remaining < 0) {
				PointCounter.finish = true; 
				CountdownTimer.stop(); 
			}
		}
	}
	
	void OnGUI(){
		if (PointCounter.finish != true){
		 Font myFont2 = (Font)Resources.Load("Fonts/8BIT", typeof(Font));
		 GUIStyle myStyle2 = new GUIStyle();
         myStyle2.font = myFont2;

         GUI.Label(new Rect(10,150,200,200), msg, myStyle2);
         if (remaining < 0){
         	msg = "Ran out of film";
         }
         else {
         	msg = "Film remaining: " + remaining.ToString();
         }
		}
	}
}
