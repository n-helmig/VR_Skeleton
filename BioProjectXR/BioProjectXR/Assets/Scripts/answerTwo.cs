using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerTwo : MonoBehaviour
{

    List<string> secondchoice = new List<string>() { 
        //Answers for the second button
        "The metatarsus",
        "Sacrum",
        "Scapula",
        "14",
        "Thumb",
        "Phalanx",
        "Spine",
        "Spine",
        "Wrist",
        "The ribs",
        "Femur",
        "Flexbility and protection",
        "14",
        "Vertebrae",
        "Ulna",
        "Humerus",
        "24",
        "Sacrum",
        "Tarsal bones",
        "The metatarson",
        "Carpal bones",
        "24",
        "18",
        "20",
        "Phalanges (hand)",
        "Carpal bones",
        "Clavicle",
        "Tibia",
        "Radius",
        "Thoratic cage",
        "Cranium",
        "Radius",
        "Scapula",
        "Mandible",
        "Vertebrae"};

    void Start()
    {
        GetComponent<Text>().text = secondchoice[0];
    }

    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<Text>().text = secondchoice[textcontrol.randQuestion];
        }
    }

}
