using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnReturn : MonoBehaviour {
	
	public Button returnButton;

	// Use this for initialization
	void Start () {
		Button btnReturn = returnButton.GetComponent<Button>();
		btnReturn.onClick.AddListener(GoToPreviousScene);
	}
	
	// Update is called once per frame
	void Update () {
        
    }

	void GoToPreviousScene () {
        //SceneManager.LoadScene("scene_accueil");
    }
}
