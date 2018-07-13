using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    int level;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu("        Select Target System");
    }

    void ShowMainMenu(string message)
    {
        currentScreen = Screen.MainMenu;
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
        if (input == "menu")  // We can always go direct to the main menu
        {
            ShowMainMenu("        Select Target System");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            StartGame(1);
        }
        else if (input == "2")
        {
            StartGame(2);
        }
        else if (input == "frak")
        {
            ShowMainMenu("Chiana says hi!  Please try again.");
        }
        else
        {
            ShowMainMenu("**Invalid Input.  Please try again.**");
        }
    }

    void StartGame(int level)
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level - " + level);
        Terminal.WriteLine("Please enter password: ");
    }
}
