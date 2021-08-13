using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    void Update()
    {
        if (textcontrol.selectedAnswer == "1" || textcontrol.selectedAnswer == "2" || textcontrol.selectedAnswer == "3" || textcontrol.selectedAnswer == "4")
        {
            if (name == textcontrol.correctAnswer[textcontrol.randQuestion])
            {
                //Correct answer turns green
                GetComponent<Image>().color = Color.green;
                GetComponentInChildren<Text>().color = Color.white; 
            }
            else
            {
                //Incorrect answer turns red
                GetComponent<Image>().color = Color.red;
                GetComponentInChildren<Text>().color = Color.white;
            }
        }
        else
        {
            //Otherwise its white
            GetComponent<Image>().color = Color.white;
            GetComponentInChildren<Text>().color = Color.black;
        }
    }
}
