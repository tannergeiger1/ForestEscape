#pragma strict

var newScene : String;

function OnTriggerEnter (Col : Collider)
{
	if (Col.CompareTag("Player"))
	{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		Application.LoadLevel (2);	
=======
	Application.LoadLevel (newScene);
>>>>>>> parent of 05631fd... fjehfiuewl
=======
	Application.LoadLevel (newScene);
>>>>>>> parent of 05631fd... fjehfiuewl
=======
	Application.LoadLevel (newScene);
>>>>>>> parent of 05631fd... fjehfiuewl
	}
	
}
	