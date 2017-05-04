using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnReturn : MonoBehaviour {
	
	public Button retrurnButton;

	// Use this for initialization
	void Start () {
        Debug.Log("TEST");
		Button btnReturn = retrurnButton.GetComponent<Button>();
		btnReturn.onClick.AddListener(GoToPreviousScene);
	}
	
	// Update is called once per frame
	void Update () {
        
    }

	void GoToPreviousScene () {
        //SceneManager.LoadScene("scene_accueil");
        variables.scene_history.ForEach(test);
        Debug.Log("TEST");
    }

    void test(string s)
    {
        Debug.Log(s);
    }
}
