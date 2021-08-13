using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcontrol : MonoBehaviour
{
    
    List <string> questions = new List <string>() {
        //All questions
        "Together, what are the metacarpal bones known as?",
        "Which bone gives pelvic girdle flexibility?",
        "What holds the upper teeth in place?",
        "How many bones are there in one hand?",
        "Which finger has the least phalanges?",
        "Many phalanges, one:",
        "What helps with mastication?",
        "What is the scapula known as?",
        "What is the patella known as?",
        "What is the thoratic cage also known as?",
        "What is the largest bone in the body?",
        "The vertebrae in the spine allow for:",
        "How many bones make up the carpal bones?",
        "What is the spine made of?",
        "Which bone stabilized the tibia and ankle joint?",
        "Which bone helps in bending the knee?",
        "How many vertebrae is the average person born with?",
        "The lower spine vertebrae fuse together to create which bone?",
        "Which bones help with bending the foot?",
        "Together, what are the metatarsal bones known as?",
        "Which bones make up the ankle and heel?",
        "How many proximal phalanges does an average human have?",
        "How many distal phalanges does an average human have?",
        "How many middle phalanges does an average human have?",
        "Which bones create a transverse arch?",
        "What bones allow for the wrist to be flexible and durable?",
        "Which bone stabilizes the radius?",
        "This bone works together with another to allow for arm movement.",
        "Which bone connects to the shoulder to allow arm movement?",
        "What protects your thoratic organs?",
        "The connecting point for the clavicle and thoratic cage?",
        "What stabilizes bones used in shoulder motion?",
        "What bone is known as the collarbone?",
        "Which bone holds your lower teeth in place?",
        "What brings structure to the head?"};

    //List holds all correct answers
    public static List<string> correctAnswer = new List<string>() {"1", "2", "3", "4", "2", "2", "3", "4", "1", "2", "2", "2", "1", "2", "3", "1", "1", "2", "3", "4", "1", "4", "3", "1", "1", "2", "3", "3", "1", "2", "3", "4", "1", "2", "3" };                                                                             

    //List puts all previous answers as a negative value
    List<int> previousQuestions = new List<int>() { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1};

    public int questionNumber = 0;

    public Transform resultObj;

    public static string selectedAnswer;

    public static bool choiceMade;

    public static int randQuestion;

    public static int score;

    public static int totalQuestions;

    public static bool testOver = false;

    void Start()
    {
        //Set all values to 0 or NULL on start

        questionNumber = 0;
        selectedAnswer = null;
        choiceMade = false;
        randQuestion = -1;
        score = 0;
        totalQuestions = 0;
        testOver = false;
        GetComponent<Text>().text = questions[0];
        
    }
    public void SetRandQuestion()
    {
        randQuestion = -1;
        resultObj.GetComponent<Text>().text = "";
    }

    public void SetBackChoice()
    {
        choiceMade = !choiceMade;
    }

    public void SetSelected(string button_name)
    {
        selectedAnswer = button_name;
    }


    void Update()
    {
        if (randQuestion == -1)
        { //If randQuestion is -1 give it a random question and make the buttons interactable
            randQuestion = Random.Range(0, 35);

            for (int i = 0; i < 35; i++) {
            if (randQuestion == previousQuestions[i]){
                    randQuestion = -1;
                }
            }

            GameObject.Find("Next").GetComponent<Button>().interactable = false;
            GameObject.Find("1").GetComponent<Button>().interactable = true;
            GameObject.Find("2").GetComponent<Button>().interactable = true;
            GameObject.Find("3").GetComponent<Button>().interactable = true;
            GameObject.Find("4").GetComponent<Button>().interactable = true;


        }

        if (randQuestion > -1)
        {
            GetComponent<Text>().text = questions[randQuestion];
            previousQuestions[questionNumber] = randQuestion;

        }
        if (choiceMade == true){

            choiceMade = false;
            questionNumber += 1;

            

            if (correctAnswer[randQuestion] == selectedAnswer) {

                resultObj.GetComponent<Text>().text = "Correct. Click Next to continue.";
                score = score + 1;
                totalQuestions = totalQuestions + 1;
                GameObject.Find("Next").GetComponent<Button>().interactable = true;
                GameObject.Find("1").GetComponent<Button>().interactable = false;
                GameObject.Find("2").GetComponent<Button>().interactable = false;
                GameObject.Find("3").GetComponent<Button>().interactable = false;
                GameObject.Find("4").GetComponent<Button>().interactable = false;
            }
            else {
                totalQuestions = totalQuestions + 1;
                resultObj.GetComponent<Text>().text = "Incorrect. Click Next to continue.";
                GameObject.Find("Next").GetComponent<Button>().interactable = true;
                GameObject.Find("1").GetComponent<Button>().interactable = false;
                GameObject.Find("2").GetComponent<Button>().interactable = false;
                GameObject.Find("3").GetComponent<Button>().interactable = false;
                GameObject.Find("4").GetComponent<Button>().interactable = false;


            }

        }

        if (totalQuestions == 15){

            GameObject.Find("ScoreText").GetComponent<Text>().text = "Test Over. You scored " + score + "/" + totalQuestions + ".";
            GameObject.Find("Next").GetComponent<Button>().interactable = false;
            resultObj.GetComponent<Text>().text = "";
            testOver = true;

        }

    }
}
