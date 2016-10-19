using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour {
	public static float timeRemaining = 40;
	public static bool paused = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!paused){
		timeRemaining -= Time.deltaTime;
		}
	}
	
	void OnGUI() {
		
		 Font myFont = (Font)Resources.Load("Fonts/8BIT", typeof(Font));
		 GUIStyle myStyle = new GUIStyle();
         myStyle.font = myFont;
		if(timeRemaining > 0){
			GUI.Label(new Rect(1, 1, 2, 1), "Time Remaining :" + timeRemaining, myStyle);
		}
		else {
			GUI.Label(new Rect(1, 1, 1, 1), "Times Up!", myStyle);
		    stop(); 
			PointCounter.finish = true; 
		}
	}
	
	public static void stop(){
		paused = true;
	}
	
}
