using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class raiseSkeleton : MonoBehaviour
{

	private XRController controller = null;
	private float heightSpeed;

	private void Awake()
	{
		controller = GetComponent<XRController>();
	}

	void Update()
	{
		controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position);
		//Middle
		if (position.y == 0)
		{
			heightSpeed = 0;

		}//Top
		else if (position.y > 0)
		{

			heightSpeed = 1 * position.y;

		}//Bottom
		else if (position.y < 0)
		{
			heightSpeed = -1 * -position.y;

		}
		//Moves the skeleton up and down inbetween two positions
		if (GameObject.Find("Podium").transform.position.y >= -1.408 && GameObject.Find("Podium").transform.position.y <= 0)
		{
			GameObject.Find("Podium").transform.Translate(Vector3.up * heightSpeed * Time.deltaTime);
		}
		else if (heightSpeed > 0 && GameObject.Find("Podium").transform.position.y <= -1.408)
		{
			GameObject.Find("Podium").transform.Translate(Vector3.up * heightSpeed * Time.deltaTime);
		}
		else if (heightSpeed < 0 && GameObject.Find("Podium").transform.position.y >= 0)
		{
			GameObject.Find("Podium").transform.Translate(Vector3.up * heightSpeed * Time.deltaTime);
		}
	}
}
