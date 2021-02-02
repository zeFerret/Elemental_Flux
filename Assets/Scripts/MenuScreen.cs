﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public void StartGame()
    {
        Destroy(FindObjectOfType<GameSession>());
        SceneManager.LoadScene(1);
        // StartCoroutine(LoadFirstLevel());
    }

    // private IEnumerator LoadFirstLevel()
    // {
    //     yield return new WaitForSeconds(2f);
    //     SceneManager.LoadScene(1);
    // }

    public void ExitGame()
    {
        Application.Quit();
    }
    
}
