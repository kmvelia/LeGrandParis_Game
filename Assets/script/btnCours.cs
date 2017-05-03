using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btnCours : MonoBehaviour
{

	public Button buttonCours;
	// Use this for initialization
	void Start() {
		Button btnCours = buttonCours.GetComponent<Button>();
		btnCours.onClick.AddListener(GoToCours);
	}

	// Update is called once per frame
	void Update() {
		
	}

	void GoToCours() {
		SceneManager.LoadScene("scene_cours");
	}
}
