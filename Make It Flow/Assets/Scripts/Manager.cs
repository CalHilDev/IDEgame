using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool playerCorrect = false;
    int levelCounter = 0;

    public void CheckCorrectness(int correctAnswers, int correctAnswersNeeded)
    {
        if(correctAnswers == correctAnswersNeeded)
        {
            playerCorrect = true; //checks if player is successful
        }
        levelComplete();
    }
    void levelComplete()
    {
        if(playerCorrect == true)
        {
            //send to player correct screen, proceed to next level
            levelCounter += 1;
            playerCorrect = false;
        }
        else
        {
            //send to player wrong screen, restart level
        }
    }
}
