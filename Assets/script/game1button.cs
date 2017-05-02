using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class game1button : MonoBehaviour {

    public Button gamebutton;

    // Use this for initialization
    void Start () {
        Screen.fullScreen = false;
        Button nextscene = gamebutton.GetComponent<Button>();
        nextscene.onClick.AddListener(TaskonClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TaskonClick()
    {
        SceneManager.LoadScene("scene_game1chooselevel");
    }
}
