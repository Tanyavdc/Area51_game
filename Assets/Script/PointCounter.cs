using UnityEngine;
using System.Collections;

public class PointCounter : MonoBehaviour {
    public static int points = 0;
    public static bool finish = false;
    string msg; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI() {
		
		 Font myFont2 = (Font)Resources.Load("Fonts/8BIT", typeof(Font));
		 GUIStyle myStyle2 = new GUIStyle();
         myStyle2.font = myFont2;
         if (!finish){
         msg = "Shots: " + points.ToString();
         }
         else {
         	if (points >= 4){
         		//win
         		myStyle2.fontSize = 10;
         		msg = "You have gathered enough evidence! Aliens Exist!" ;
         	}
         	else {
         		myStyle2.fontSize = 10;
         		msg = "You have not gathered enough evidence. No one believes you" ;
         	}
         }
         GUI.Label(new Rect(10,100,200,200), msg, myStyle2);
		}
}

