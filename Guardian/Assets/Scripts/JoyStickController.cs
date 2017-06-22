/*
*	Copyright (C) Amit Kumar Gupta
*	Created by Amit Kumar Gupta
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoyStickController : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    #region Variables

    private Image joyBack;
    private Image joyStick;

    private Vector3 inputDirection;

	#endregion

	void Start ()
	{
        joyBack = GetComponent<Image>();
        joyStick = transform.GetChild(0).GetComponent<Image>();
        inputDirection = Vector3.zero;
	}

	public void OnDrag(PointerEventData data)
    {
        Vector2 position = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(joyBack.rectTransform, data.position, data.pressEventCamera, out position);

        position.x /= joyBack.rectTransform.sizeDelta.x;
        position.y /= joyBack.rectTransform.sizeDelta.y;

        float x = (joyBack.rectTransform.pivot.x == 1f) ? position.x * 2 + 1 : position.x * 2 - 1;
        float y = (joyBack.rectTransform.pivot.y == 1f) ? position.y * 2 + 1 : position.y * 2 - 1;

        inputDirection = new Vector3(x, y, 0);
        inputDirection = (inputDirection.magnitude > 1) ? inputDirection.normalized : inputDirection;
        joyStick.rectTransform.anchoredPosition = new Vector3(inputDirection.x * (joyBack.rectTransform.sizeDelta.x / 3) , inputDirection.y * (joyBack.rectTransform.sizeDelta.y) / 3);
    }

    public void OnPointerUp(PointerEventData data)
    {
        inputDirection = Vector3.zero;
        joyStick.rectTransform.anchoredPosition = Vector3.zero;
    }

    public void OnPointerDown(PointerEventData data)
    {
        OnDrag(data);
    }

    public Vector3 getInputDirection()
    {
        return inputDirection;
    }
}
