using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilsi_Graph_Simulation
{
      class Program
      {
            static void Main(string[] args)
            {

                  double prey = 10.0;
                  double predator = 5.0;
                  int t = 0;
                  double gr_pray = 0.09;
                  double dr_pray = 0.01;
                  double gr_pred = 0.01;
                  double dr_pred = 0.04;

                  // double dr_pred = double.Parse(Console.ReadLine());

                  Console.WriteLine("Initial prey = " + prey.ToString() + " predators = " + predator.ToString());

                  Console.WriteLine("Prey growth rate= " + gr_pray.ToString() + " prey death rate= " + dr_pray.ToString() + " Predator growth rate = " + gr_pred.ToString() + " predator death rate = " + dr_pred.ToString());

                  Console.WriteLine("\ntime" + "\t" + "prey" + "\t" + "predators");
                  if ((!File.Exists("pry.txt"))) //Checking if pry.txt exists or not
                  {
                        FileStream pry = File.Create("./pry.txt"); //Creates pry.txt
                        pry.Close(); //Closes file stream
                  }
                  if ((!File.Exists("pred.txt"))) //Checking if pred.txt exists or not
                  {
                        FileStream pred = File.Create("./pred.txt"); //Creates pred.txt
                        pred.Close(); //Closes file stream
                  }
                  if ((!File.Exists("title.txt"))) //Checking if title.txt exists or not
                  {
                        FileStream pred = File.Create("./title.txt"); //Creates title.txt
                        pred.Close(); //Closes file stream
                  }
                  StreamWriter writer1 = new StreamWriter("./pry.txt");
                  StreamWriter writer2 = new StreamWriter("./pred.txt");
                  StreamWriter writer3 = new StreamWriter("./title.txt");
                  string graph_title = "Predator-Prey Population Growth (Lotka-Volterra Model)";
                  string x_axis_title = "Time-Step";
                  string y_axis_title = "Predator-Red Vs prey-Blue";


                  writer3.WriteLine(graph_title);
                  writer3.WriteLine(x_axis_title);
                  writer3.WriteLine(y_axis_title);

                  writer3.Close();

                  for (int i = 0; i < 300; ++i)
                  {
                        Console.WriteLine(t + "\t" + prey.ToString("") + "\t" + predator.ToString(""));
                        double dx = (gr_pray * prey) - (dr_pray * prey * predator);
                        double dy = (gr_pred * prey * predator) - (dr_pred * predator);
                        int dt = 1;

                        prey = prey + dx;
                        predator = predator + dy;
                        t = t + dt;
                        /*string converter1 = prey
                         * .ToString();
                        string converter2 = predator.ToString("#.##");*/
                        writer1.WriteLine(prey);
                        /*Thread.Sleep(5);*/
                        writer2.WriteLine(predator);
                        /*Thread.Sleep(5);*/
                        /*Console.WriteLine("index: " + i);*/


                  }
                  writer1.Close();
                  writer2.Close();
                  try
                  {
                        /*                string c_directory = Directory.GetCurrentDirectory();
                                        Console.WriteLine(c_directory);*/
                        System.Diagnostics.Process.Start(".\\main.exe");
                        /*System.Diagnostics.Process.Start("./pry.txt");*/
                  }
                  catch (Exception e)
                  {
                        Console.WriteLine(e);

                  }
            }
      }
}
