using System;
using System.Collections.Generic;

public class Logic
{
    public Random a = new Random();

    public List<int> randomList = new List<int>();
    int MyNumber = 0;
    public List<string> Amigos = new List<string>();
    string FinalAmigos = "";

    private void NewNumber()
    {
        MyNumber = a.Next(0, 7);
        if
             (!randomList.Contains(MyNumber)) { 
            randomList.Add(MyNumber);
        } else
        {
            NewNumber();
        }
    }

    public void Generate()
    {
        string[] team = { "AllanW", "Alan R", "Agnes", "Athos", "Mikey", "Mark", "Alan S" };


        for (int i= 0; i< 3; i++)
        {
            NewNumber();
        }
        foreach (int number in randomList)
        {
            Amigos.Add(team[number]);
        }
    }

    public string ThreeAmigos()
    {
        foreach (string dude in Amigos)
        {
            FinalAmigos = FinalAmigos + dude + " ";
        }
        return FinalAmigos;
    }

}

