using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndex;
    private int currentSceneIndex;
    void Start()
    {
        sceneIndex = 1;
        currentSceneIndex = 1;

        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //sceneIndex++;
            //LoadNextScene();
        }

        if (sceneIndex != currentSceneIndex)
        {
            SceneManager.UnloadScene(currentSceneIndex);
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
            currentSceneIndex = sceneIndex;
        }
    }

    private void LoadNextScene()
    {
        SceneManager.UnloadScene(sceneIndex - 1);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }
}
