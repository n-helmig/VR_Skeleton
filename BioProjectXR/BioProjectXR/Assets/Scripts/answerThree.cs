using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerThree : MonoBehaviour
{

    List<string> thirdchoice = new List<string>() {
        //Answers for the third button
        "The metacarpet",
        "Femur",
        "Cranium",
        "10",
        "Middle finger",
        "Phalynx",
        "Mandible",
        "Jaw",
        "Shoulder blade",
        "The back",
        "Fibula",
        "Sturdiness and stiffness",
        "7",
        "Metacarpal bones",
        "Fibula",
        "Tibia",
        "14",
        "Femur",
        "Phalanges (foot)",
        "The metatarget",
        "Metatarsal bones",
        "18",
        "20",
        "24",
        "Carpal bones",
        "Ulna",
        "Ulna",
        "Radius",
        "Clavicle",
        "Thoratic sanctuary",
        "Sternum",
        "Sacrum",
        "Mandible",
        "Cranium",
        "Cranium"};

    void Start()
    {
        GetComponent<Text>().text = thirdchoice[0];
    }

    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<Text>().text = thirdchoice[textcontrol.randQuestion];
        }
    }
}