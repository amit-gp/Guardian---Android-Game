/*
*	Copyright (C) Amit Kumar Gupta
*	Created by Amit Kumar Gupta
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BannerScript : MonoBehaviour
{
	#region Variables

	#endregion

    IEnumerator WaitForDDOL()
    {
        yield return new WaitForSeconds((float) 1.5);
        SceneManager.LoadScene(1);
    }

	void Start ()
	{
        StartCoroutine(WaitForDDOL());
	}

}
