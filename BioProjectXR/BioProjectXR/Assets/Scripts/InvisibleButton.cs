using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvisibleButton : MonoBehaviour
{

	private void Start()
	{
        //Buttons are uninteractable and invisible
        GetComponent<Button>().interactable = false;
        GetComponent<Image>().color = Color.clear;
        GetComponentInChildren<Text>().color = Color.clear;
    }

	void Update()
    {
        //Buttons become interactable and visible once the test is over
        if (textcontrol.testOver == true)
        {
            GetComponent<Button>().interactable = true;
            GetComponent<Image>().color = Color.white;
            GetComponentInChildren<Text>().color = Color.black;
        }
        else
        {
            GetComponent<Button>().interactable = false;
            GetComponent<Image>().color = Color.clear;
            GetComponentInChildren<Text>().color = Color.clear;
        }


    }
}
