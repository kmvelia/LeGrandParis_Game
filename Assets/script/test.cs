using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown()
    {
        try
        {
            if (variables.scene_history.Count >= 2)
                SceneManager.LoadScene(variables.scene_history[variables.scene_history.Count - 2]);
            else
                SceneManager.LoadScene("scene_accueil");
        }
        catch (Exception e)
        {
            SceneManager.LoadScene("scene_accueil");
        }
    }
}