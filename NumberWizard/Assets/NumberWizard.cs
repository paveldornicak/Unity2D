using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;

    void Start()
    {
        MainMenu();
    }

    void MainMenu()
    {
        min = 1;
        max = 1000;
        guess = 500;

        Debug.Log("Welzome the the Number Wizard game");
        Debug.Log("Pick a number, please");
        Debug.Log($"Lowest number is {min}");
        Debug.Log($"Highest number is {max}");
        Debug.Log($"Tell me if your number is higher or lower than {guess}");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You know my number");
            MainMenu();
        }
    }
    
    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log($"It is higher or lower than {guess}");
    }
}
