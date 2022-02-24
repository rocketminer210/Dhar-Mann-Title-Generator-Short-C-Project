using System;
using System.Collections.Generic;


class Program{
  public static void Main (string[] args) 
    {
    string[] options1 = {"Young Kid", "Racist Employee", "Spoiled Kid", "Rich Girl"};
  string[] options2 = {" Bullies ", " Insults ", " Is Racist To ", " Humiliates " , " Mocks ", " Makes Fun Of ", " Attacks "};
  string[] options3 = {"Gay Man, ","Stinky Rat, ", "Mexican Lady, ", "African-American Man, ", "Poor Kid, ", "Teenage Cashier, "};
  string[] options4 = {"Lives To Regret It.", "See What Will Happen. Feat. RiceGum", "What Happens Next Will Shock You.", "What Happens Next Is Shocking.", "Instantly Regrets It."};
  /*List<string> firstSection = new List<string>(options1);
  List<string> secondSection = new List<string>(options2);
  List<string> thirdSection = new List<string>(options3);
  List<string> fourthSection = new List<string>(options4);*/

  List<string[]> sections = new List<string[]>();
  sections.Add(options1);
  sections.Add(options2);
  sections.Add(options3);
  sections.Add(options4);
    //for (int i = 0; i < (sections.Count); i++)
    foreach (string[] currentSection in sections)
      {
      var rand = new Random();
      //List<string[]> currentSection = new List<string[]>();
      //currentSection.Add(sections[i]);
      Console.Write(currentSection[rand.Next(currentSection.Length)]);
        
      }
    
    }
}
