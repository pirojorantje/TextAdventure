using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelja,
        deelnee,
        deeltadres,
        politie,
    }

    private States CurrentState = States.start; 
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
        ShowMainMenu();
    }


    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij Delen of houden");
        Terminal.WriteLine("Dit verhaal is waargebeurd");
        Terminal.WriteLine("Typ start om door te gaan");
    }

    void OnUserInput(string input)
    {

            if (input == "hoi")
            {
                CurrentState = States.intro2;
                Terminal.ClearScreen();
                startdelen();
            }

            if (input == "ja")
            {
                CurrentState = States.delen;
                Terminal.ClearScreen();
                startdeelja();
            }else if (input == "nee")
            {
                CurrentState = States.delen;
                Terminal.ClearScreen();
                startdeelnee();
            }

            if (input == "gezellig")
            {
                CurrentState = States.deelja;
                Terminal.ClearScreen();
                startdeeltadres();
            }

            if (input == "112")
            {
                CurrentState = States.deelnee;
                Terminal.ClearScreen();
                startpolitie();
            }
            
            if (input == "opnieuw")
            {
                Terminal.ClearScreen();
                ShowMainMenu();
            }

        if (CurrentState == States.start)
        {
            if (input == "start")
            {
                CurrentState = States.intro1;
                StartIntro();
            }else if(input == "easteregg")
            {
                Terminal.WriteLine("You found me!!");
            }else if(input == "verder")
            {
                Terminal.ClearScreen();
            }else
            {
                Terminal.WriteLine("Commando wordt niet herkend!");
            }
        }
            if(input == "verder")
            {
                CurrentState = States.intro1;
                Terminal.ClearScreen();
                StartIntro2();
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een warme kerst avond");
        Terminal.WriteLine("Ian speelde fortnite, en");
        Terminal.WriteLine("Ruud zat op de bank tv te kijken.");
        Terminal.WriteLine("Een telefoontje van de radio kwam binnen");
        Terminal.WriteLine("Typ verder om door te gaan.");
    }

    void StartIntro2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je chat nu samen met Ruud..");
        Terminal.WriteLine("Hallo? Is daar iemand?");
        Terminal.WriteLine("Typ hoi om door te beginnen.");
    }

    void startdelen()
    {
        Terminal.WriteLine("Ohh hey, daar ben je!");
        Terminal.WriteLine("Ik heb een probleem..");
        Terminal.WriteLine("De spelshow op de radio");
        Terminal.WriteLine("is gestart, de keuze is");
        Terminal.WriteLine("Delen of houden.");
        Terminal.WriteLine("Misschien ken je het wel,");
        Terminal.WriteLine("Maar wat zou jij kiezen?");
        Terminal.WriteLine("Typ ja voor delen, en nee voor houden");
    }

    void startdeelja()
    {
        Terminal.WriteLine("Je koos voor delen.");
        Terminal.WriteLine("Yes! Gewonnen, beide deelnemers");
        Terminal.WriteLine("delen nu de winst, van 10.000€");
        Terminal.WriteLine("Dankzij jou heb ik nu 5.000€ gewonnen!");
        Terminal.WriteLine("Wil je samen wat drinken in het cafe?");
        Terminal.WriteLine("Ik betaal! Wil je mee?");
        Terminal.WriteLine("Typ gezellig om door te gaan.");
    }

    
    void startdeelnee()
    {
        Terminal.WriteLine("Je koos voor houden.");
        Terminal.WriteLine("Shit, verloren! Wacht eens even");
        Terminal.WriteLine("jij wist dit.. Je wist dat dit");
        Terminal.WriteLine("zou gebeuren, door jou loop ik geld mis!");
        Terminal.WriteLine("Dit gaat je door komen te staan.");
        Terminal.WriteLine("Ik weet waar je woont, pas maar op!");
        Terminal.WriteLine("*Ruud heeft opgehangen*");
        Terminal.WriteLine("Typ 112, om de politie te bellen.");
    }

    void startpolitie()
    {
        Terminal.WriteLine("Meldkamer, zegt u het maar.");
        Terminal.WriteLine("Oei dat is niet wenselijk,");
        Terminal.WriteLine("Wij zorgen deze man vanavond");
        Terminal.WriteLine("Nog vastzit op het bureau.");
        Terminal.WriteLine("*Pistoolschot*");
        Terminal.WriteLine("Ja, hallo dit is Ruud. De melder ziet u niet meer levend terug.");
        Terminal.WriteLine("Je hebt de verkeerde beslissing genomen, hierdoor ben je niet meer in leven.");  
        Terminal.WriteLine("Typ opnieuw, om het spel nogmaals te spelen.");
    }

    void startdeeltadres()
    {
        Terminal.WriteLine("Leuk! Ik zie je vanavond om 9 uur.");
        Terminal.WriteLine("In het cafe, op het adres");
        Terminal.WriteLine("Daltonlaan 301. Tot dan!");
        Terminal.WriteLine("*Je hebt succesvol Ruud geholpen.");
        Terminal.WriteLine("Typ opnieuw, om het spel nogmaals te spelen.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
