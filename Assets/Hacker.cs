using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ShowMainMenu("        Select Target System");
    }

    void ShowMainMenu(string message)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Anodyne Sytems Terminal Interface v1.8\n");
        Terminal.WriteLine("\n"+message+"\n");
        Terminal.WriteLine("1. Natalie's Cell Phone");
        Terminal.WriteLine("2. Amaretto High School");
        Terminal.WriteLine("3. Reliable Construction Inc\n");
    }

    void OnUserInput(string input)
    {
        print("The user typed: " + input);
        if (input == "menu")
        {
            ShowMainMenu("        Select Target System");
        }
        else if (input == "frak")
        {
            ShowMainMenu("Chiana says hi!  Please try again.");
        }
        else
        {
            ShowMainMenu("Invalid Input.  Please try again.");
        }

    }
}
