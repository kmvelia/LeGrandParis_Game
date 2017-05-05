using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class switch_scene : MonoBehaviour {

	public Button actionButton;
	public int levelIndex;

	// Use this for initialization
	void Start()
	{
		Button btn = actionButton.GetComponent<Button>();
		btn.onClick.AddListener(LoaderScene);
	}

	// Update is called once per frame
	void Update()
	{

	}

	// Load Scene stock in Arrays of String 
	void LoaderScene()
	{ 
		string[] sceneName = { "scene_accueil", // 0
			"scene_cours", // 1
			"scene_game1chooselevel", // 2
			"scene_game1debutant", // 3
			"scene_game1debutant_region", // 4
			"Game1_cours", // 5
			"Game2_cours"}; // 6
		SceneManager.LoadScene(sceneName[levelIndex]);
	}
}
