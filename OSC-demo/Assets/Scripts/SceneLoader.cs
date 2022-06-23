using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndex;
    void Start()
    {
        sceneIndex = 1;
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sceneIndex++;
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        SceneManager.UnloadScene(sceneIndex - 1);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }
}
