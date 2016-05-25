using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class UIManager : MonoBehaviour
	
{                         // Reference to the animator component.
	GameObject[] pauseObjects;
	public GameObject player;
	private CharacterController controller;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
		controller = player.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetMouseButton (0)) {
			pauseControl();
		}
		
		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.P))
			
		{
			
			if(Time.timeScale == 1)
				
			{
				Time.timeScale = 0;
				GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
				
				showPaused();
			} else if (Time.timeScale == 0){
				Debug.Log ("high");
				Time.timeScale = 1;
				hidePaused();
				GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
				
			}
		}
	}
	//Reloads the Level
	public void Reload(){
		DontDestroyOnLoad (controller);
		Application.LoadLevel(Application.loadedLevel);
	}
	
	//controls the pausing of the scene
	public void pauseControl(){
		
		Debug.Log ("press");
		
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
			showPaused();
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			hidePaused();
			GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
		}
	}
	
	
	//shows objects with ShowOnPause tag
	public void showPaused(){
		DontDestroyOnLoad (controller);
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}
	
	
	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}
	
	//loads inputted level
	public void LoadLevel(string level){
		DontDestroyOnLoad (controller);
		Application.LoadLevel (level);
	}
}

