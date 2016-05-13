using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	void OnMouseDown() {
		Play();
	}
	void Play() {
		Application.LoadLevel("Scene_1");
	}
}