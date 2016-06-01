using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public string scene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button(new Rect(0,0,100,30), "start")){
			Initiate.Fade(scene,Color.green,0.5f);
	
	}
}
}