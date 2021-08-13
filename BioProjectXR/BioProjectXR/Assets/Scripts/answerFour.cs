using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerFour : MonoBehaviour
{

    List<string> fourthchoice = new List<string>() {
        //Answers for the four button
        "The metacarpon",
        "Thoratic cage",
        "Patella",
        "27",
        "Ring finger",
        "Phalax",
        "Tarsal bones",
        "Shoulder blade",
        "Fingers",
        "The soul",
        "Humerus",
        "Flexibility and warmth",
        "24",
        "Metatarsal bones",
        "Ilium",
        "Femur",
        "7",
        "Scapula",
        "Fibula",
        "The metatarsus",
        "Phalanges (foot)",
        "20",
        "16",
        "18",
        "Metatarsal bones",
        "Metacarpal bones",
        "Humerus",
        "Ulna",
        "Ulna",
        "Femur",
        "Clavicle",
        "Scapula",
        "Scapula",
        "Ilium",
        "Clavicle",
        "Mandible"};

    void Start()
    {
        GetComponent<Text>().text = fourthchoice[0];
    }

    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<Text>().text = fourthchoice[textcontrol.randQuestion];
        }
    }
}