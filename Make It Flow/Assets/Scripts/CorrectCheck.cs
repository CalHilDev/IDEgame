using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectCheck : MonoBehaviour
{
    [SerializeField] public string correctValue;
    public string currentValue;
    public bool isCorrect = false;

    public void GetCurrentValue(string parsedValue)
    {
        currentValue = parsedValue;
        SetIsCorrect();
        //Debug.Log(parsedValue);
    }

    public void SetIsCorrect()
    {
        if(currentValue == correctValue)
        {
            isCorrect = true;
            Debug.Log("correct");
        }
    }
}
