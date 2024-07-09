using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int correctAnswersNeeded;
    public int correctAnswersGiven;
    public Manager manager;
    public List<bool> answers;
    public bool answerCheck;

    private void Start()
    {
        manager = FindObjectOfType<Manager>();
    }

    public void ReceiveAnswers(bool isCorrect)
    {
        answerCheck = isCorrect;
        answers.Add(answerCheck);
        foreach (bool answerCheck in answers)
        {
            correctAnswersGiven++; //checks how many right answers the user gives
        }
        /*if(answers.length == correctAnswersNeeded)
        {
            manager.CheckCorrectness(correctAnswersGiven, correctAnswersNeeded);
        }*/
    }
}
