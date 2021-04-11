using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Text;

namespace ConsoleFileManager
{
    public class Program
    {
        
        // Точка входа
        static void Main(string[] args)
        {
            StartProgramm();
        }

        // Метод работающий с классами FileManagerUI и FileManagerFunc
        static void StartProgramm()
        {
            FileManagerUI userInterface = new FileManagerUI();
            userInterface.UI();

            FileManagerFunc function = new FileManagerFunc();
            function.PrintMenu();
        }   


        

        



        

        

        

        

        

        

        

        

        

        

        

        

       

        

        
    }
}