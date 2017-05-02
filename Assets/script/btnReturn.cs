using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnReturn : MonoBehaviour {
	
	public Button retrurnButton;

	// Use this for initialization
	void Start () {
		Button btnReturn = retrurnButton.GetComponent<Button>();
		btnReturn.onClick.AddListener(GoToPreviousScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GoToPreviousScene () {
		SceneManager.LoadScene("scene_accueil");
	}
}
