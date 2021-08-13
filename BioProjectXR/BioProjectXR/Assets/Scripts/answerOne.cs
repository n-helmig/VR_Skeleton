using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class answerOne : MonoBehaviour
{
    List<string> firstchoice = new List<string>() {
        //Answers for the first button
        "The metacarpus",
        "Ilium",
        "Mandible",
        "24",
        "Pointer finger",
        "Phalanc",
        "Humerus",
        "Heel",
        "Kneecap",
        "The collarbone",
        "Spine",
        "Density and warmth",
        "8",
        "Phalanges",
        "Femur",
        "Patella",
        "33",
        "Ilium",
        "Metatarsal bones",
        "The matacarpus",
        "Tarsal bones",
        "16",
        "24",
        "16",
        "Metacarpal bones",
        "Tarsal bones",
        "Scapula",
        "Humerus",
        "Humerus",
        "Mandible",
        "Sacrum",
        "Sternum",
        "Clavicle",
        "Sternum",
        "Ilium"};

    void Start()
    {
        GetComponent<Text>().text = firstchoice[0];
    }

    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<Text>().text = firstchoice [textcontrol.randQuestion];
        }
    }
}
