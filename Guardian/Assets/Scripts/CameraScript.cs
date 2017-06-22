/*
*	Copyright (C) Amit Kumar Gupta
*	Created by Amit Kumar Gupta
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    #region Variables

    public GameObject player;
    public Vector3 offset;
	#endregion

	void Start ()
	{
        offset = transform.position - player.transform.position;
	}

	void Update ()
	{
        transform.position = player.transform.position + offset;
	}
}
