                                            using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Loading H4cKz.exe...");
        Terminal.WriteLine("Loading Complete!");
        Terminal.WriteLine("Choose what to hack into:");
        Terminal.WriteLine("Enter 1 to hack Neighbour's WIFI");
        Terminal.WriteLine("Enter 2 to hack NeverHacked.com");
        Terminal.WriteLine("Enter 3 to hack Ḛ̷͆r̵̛͕̎͝r̶̢͌ơ̷̡͇̊͝r̸");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Type 'menu' anytime to return here.");
    }

    //Variables
    int level;
    string currentScreen = "MainMenu";

    string[] level1Passwords = { "password", "admin", "cat", "dog", "lemon" };
    string[] level2Passwords = { "cloak", "landlord", "orbit", "albatross", "darkness" };
    string[] level3Passwords = { "enigma", "amalgam", "apprehension", "torment", "zenith" };

    string password;

    void OnUserInput(string input)
    {

        if (input == "menu")
        {
            ShowMainMenu();
            currentScreen = "MainMenu";

        } else if (currentScreen == "MainMenu")
        {
            SetLevel(input);

        } else if (currentScreen == "Password")
        {
            CheckPassword(input);
        }

    }

    void SetLevel(string chosenLevel)
    {
        if (chosenLevel == "1")
        {
            level = 1;
            StartGame();

        } else if (chosenLevel == "2")
        {
            level = 2;
            StartGame();

        } else if (chosenLevel == "3")
        {
            level = 3;
            StartGame();

        } else
        {
            Terminal.WriteLine("Incorrect Input. Try again.");
        }
        print(level);
    }

    void StartGame()
    {

        currentScreen = "Password";
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen level " + level);

        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                break;
        }
        Terminal.WriteLine(password.Anagram());
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Hack Successful! Downloading data...");
        } else
        {
            Terminal.WriteLine(@"      ____
     /___/\_
    _\   \/_/\__
  __\       \/_/\  ERROR! Try Again!
  \   __    __ \ \
 __\  \_\   \_\ \ \   __
/_/\\   __   __  \ \_/_/\
\_\/_\__\/\__\/\__\/_\_\/
   \_\/_/\       /_\_\/
      \_\/       \_\/");
            Terminal.WriteLine(password.Anagram());
        }
    }

}