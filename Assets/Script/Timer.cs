using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 15f;
    [SerializeField] float timeToShowCorrectAnswer = 5f;
    
    public bool loadNextQuestion;
    public float fillFraction;
    public bool isAnswerningQuestions;
    float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }

    public void  CancelTimer()
    {
        timerValue = 0;
    }
    void UpdateTimer()
    {
        timerValue -= Time.deltaTime; 

        if(isAnswerningQuestions)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnswerningQuestions = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnswerningQuestions = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
        Debug.Log(isAnswerningQuestions + ": " + timerValue + " = " + fillFraction);
    }
}
