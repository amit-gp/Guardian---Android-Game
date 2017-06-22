/*
*	Copyright (C) Amit Kumar Gupta
*	Created by Amit Kumar Gupta
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    #region OnClickMethods

    public void OnClickStartButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnClickSettingstButton()
    {
        Debug.Log("Settings");
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }
    #endregion
}
