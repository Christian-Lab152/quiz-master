using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorekepper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;
    
    public int GetCorrectAnswer()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionstSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
