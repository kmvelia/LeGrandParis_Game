using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game1lvldebutant : MonoBehaviour {

    public Button gamebutton;

    // Use this for initialization
    void Start ()
    {
        Button nextscene = gamebutton.GetComponent<Button>();
		nextscene.onClick.AddListener(TaskonClick);
    }	
	// Update is called once per frame
	void Update () {

	}

    public void TaskonClick()
    {
        SceneManager.LoadScene("scene_game1debutant");
    }
}
