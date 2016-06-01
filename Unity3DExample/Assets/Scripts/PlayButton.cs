using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	void OnMouseDown() {
		Play();
	}
	void Play() {
<<<<<<< HEAD
		Application.LoadLevel("Level1");
=======
		Application.LoadLevel(1);
>>>>>>> refs/remotes/origin/master
	}
}