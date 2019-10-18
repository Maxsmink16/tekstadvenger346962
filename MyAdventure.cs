using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{

    private enum States
    {
        menu,
        dood1,
        dood2,
        dood3,
        dood4,
        keuze1,
        keuze2,
        keuze3,
        keuze4,
        leven,
    }
    private States currentState = States.menu;

    void Start()
    {
        menu();
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.menu:
                if (input == "start")
                {
                    keuze1();
                }
                else
                {
                    menu();
                }
                break;

            case States.keuze1:
                if (input == "stil")
                {
                    keuze2();
                }
                else if (input == "HELP")
                {
                    dood1();
                }
                else
                {
                    keuze1();
                }
                break;

            case States.keuze2:
                if (input == "zoek")
                {
                    keuze3();
                }
                else if (input == "overnachten")
                {
                   dood2();
                }
                else
                {
                    keuze2();
                }
                break;

            case States.dood1:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    dood1();
                }
                break;

            case States.keuze3:
                if (input == "skip")
                {
                    keuze4();
                }
                else if (input == "binnen")
                {
                    dood3();
                }
                else
                {
                    keuze3();
                }
                break;

            case States.dood2:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    dood2();
                }
                break;

            case States.keuze4:
                if (input == "kijk")
                {
                    leven();
                }
                else if (input == "draaien")
                {
                    dood4();
                }
                else
                {
                    keuze4();
                }
                break;

            case States.dood3:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    dood3();
                }
                break;

            case States.dood4:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    dood4();
                }
                break;

            case States.leven:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    leven();
                }
                break;
        }
    }

    void menu()
    {
        currentState = States.menu;
        Terminal.ClearScreen();
        Terminal.WriteLine("welkom bij het dolhof");
        Terminal.WriteLine("type start om te beginnen");
        Terminal.WriteLine("type info voor het verhaal");
    }

    void keuze1()
    {
        currentState = States.keuze1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent verdwaald in het bos");
        Terminal.WriteLine("je weet niet waar je bent");
        Terminal.WriteLine("type HELP om hulp te roepen");
        Terminal.WriteLine("type stil om geen wilde dieren aan te trekken");
    }
    void keuze2()
    {
        currentState = States.keuze2;
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent stil gebleven");
        Terminal.WriteLine("de wilde dieren hebben niks gehoord ");
        Terminal.WriteLine("type zoek om de bewoonde wereld te zoeken");
        Terminal.WriteLine("type overnachten om te wachten totdat het ochtend is");
    }

    void dood1()
    {
        currentState = States.dood1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je riep hulp de wilde dieren hebben je gevonden");
        Terminal.WriteLine("je bent dood");
        Terminal.WriteLine("type terug");
    }

    

    void dood2()
    {
        currentState = States.dood2;
        Terminal.ClearScreen();
        Terminal.WriteLine("overnachten");
        Terminal.WriteLine("je word opgegeten in je slaap");
        Terminal.WriteLine("type terug om opnieuw te beginnen");
    }

    void keuze3()
    {
        currentState = States.keuze3;
        Terminal.ClearScreen();
        Terminal.WriteLine("je komt een huisje tegen");
        Terminal.WriteLine("ga je naar binnen");
        Terminal.WriteLine("type binnen om naar binnen te gaan");
        Terminal.WriteLine("type skip omlangs het huis te lopen");
    }


    void keuze4()
    {
        currentState = States.keuze4;
        Terminal.ClearScreen();
        Terminal.WriteLine("je hoort geluiden");
        Terminal.WriteLine("ga je kijken of daai je om");
        Terminal.WriteLine("type kijk om te kijken");
        Terminal.WriteLine("type draaien om, om te draaien");
    }

    void dood3()
    {
        currentState = States.dood3;
        Terminal.ClearScreen();
        Terminal.WriteLine("je gaat naar binnen en er zit een monster in het huis");
        Terminal.WriteLine("je word opgegeten");
        Terminal.WriteLine("je bent dood");
        Terminal.WriteLine("type terug om opnieuw te beginnen");

    }

    void dood4()
    {
        currentState = States.dood4;
        Terminal.ClearScreen();
        Terminal.WriteLine("je draait je om");
        Terminal.WriteLine("de wilde dieren grijpen je");
        Terminal.WriteLine("type terug om opnieuw te beginnen");
    }

    void leven()
    {
        currentState = States.leven;
        Terminal.ClearScreen();
        Terminal.WriteLine("je vind de weg");
        Terminal.WriteLine("je ma mee liften naar huis");
        Terminal.WriteLine("type terug om opnieuw te beginnen");
    }

}

