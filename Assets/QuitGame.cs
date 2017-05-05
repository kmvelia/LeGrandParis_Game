using UnityEngine;
using UnityEngine.UI;

public class QuitGame: MonoBehaviour {

	public Button btnQuit;

	void Update() {
		Application.Quit();

		Debug.Log(btnQuit);
	}

}
