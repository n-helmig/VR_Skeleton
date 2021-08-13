using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class rotateSkeleton : MonoBehaviour
{

	private XRController controller = null;
	private float rotateSpeed;

	private void Awake()
	{
		controller = GetComponent<XRController>();
	}

	void Update()
	{
		controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position);
		//Middle
		if (position.x == 0)
		{
			rotateSpeed = 0;

		}//Right
		else if (position.x > 0)
		{
			rotateSpeed = -45 * position.x;

		}//Left
		else if (position.x < 0)
		{
			rotateSpeed = 45 * -position.x;

		}

		//Rotates skeleton
		GameObject.Find("Podium").transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
	}
}
