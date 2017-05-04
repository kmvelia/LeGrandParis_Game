using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class variables : MonoBehaviour {

    public static List<string> scene_history;

    // Use this for initialization
    void Start () {
        GameObject[] _variables = GameObject.FindGameObjectsWithTag("variables");
        if (_variables.Length <= 1)
        {
            DontDestroyOnLoad(transform.gameObject);
            SceneManager.activeSceneChanged += OnSceneLoaded;
            scene_history = new List<string>();
            scene_history.Add(SceneManager.GetActiveScene().name);
        }
    }

    void OnSceneLoaded(Scene previousScene, Scene newScene)
    {
        if (scene_history.Count <= 1)
            scene_history.Add(SceneManager.GetActiveScene().name);
        else if (string.Compare(scene_history[scene_history.Count - 2], newScene.name) != 0)
            scene_history.Add(SceneManager.GetActiveScene().name);
        else
            scene_history.RemoveAt(scene_history.Count - 1);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
