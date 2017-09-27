using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour {

    public static string debugText = "test";
    Rect debugTextLocation = new Rect(10, 10, 200, 100);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.Label(this.debugTextLocation, debugText);
    }
}
