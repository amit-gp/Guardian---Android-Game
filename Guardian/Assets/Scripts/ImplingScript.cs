/*
*	Copyright (C) Amit Kumar Gupta
*	Created by Amit Kumar Gupta
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImplingScript : MonoBehaviour
{
    #region Variables

    Animator animator;    
    public float maxSpeedMultiplier = 3.0f;
    public JoyStickController joyStickController;
    CharacterController characterController;
	#endregion

	void Start ()
	{
        animator = gameObject.GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
	}

	void Update ()
	{      
        Vector2 direction = joyStickController.getInputDirection();
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        Debug.Log(angle);

        if(angle != 0)
        {
            transform.eulerAngles = new Vector3(0, angle, 0);

            if(direction.magnitude > 0.1)
            {
                Vector3 movement = transform.forward * Time.deltaTime * maxSpeedMultiplier * (direction.magnitude);
                transform.position += movement;
            }            
        }
        
        animator.SetFloat("Speed", direction.magnitude);
	}
}
