using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using extOSC;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndex;
    private int currentSceneIndex;

    public OSCReceiver oscReceiver;
    
    void Start()
    {
        currentSceneIndex = sceneIndex;
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);

        oscReceiver.Bind("/sceneIndex", ReceiveMessage);
    }

    private void LoadScene()
    {
        if (sceneIndex != currentSceneIndex)
        {
            SceneManager.UnloadScene(currentSceneIndex);
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
            currentSceneIndex = sceneIndex;
        }
    }

    private void ReceiveMessage(OSCMessage message)
    {
        Debug.LogFormat("Received: {0}", message);
        sceneIndex = message.Values[0].IntValue;

        LoadScene();
    }

}