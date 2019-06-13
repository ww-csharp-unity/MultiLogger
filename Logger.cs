using System;
using UnityEngine;
using System.IO;

public class Logger : MonoBehaviour
{
    string file = $"C:\\Users\\{Environment.UserName}\\Documents\\FireFall Games\\Key Blaster\\kb_log.txt";

    private void Start()
    {
        BeginLog();
    }

    public void BeginLog()
    {
        //If folder doesn't exist in Docs, create...
        if (!Directory.Exists($"C:\\Users\\{Environment.UserName}\\Documents\\FireFall Games")) {
            Directory.CreateDirectory($"C:\\Users\\{Environment.UserName}\\Documents\\FireFall Games");
            Directory.CreateDirectory($"C:\\Users\\{Environment.UserName}\\Documents\\FireFall Games\\Key Blaster");
        }
        //If log file doesn't exist in Docs, create...
        if (!File.Exists(file))
        {
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Creating log file...");
                sw.WriteLine("**************************************************");
            }
        }
    }

    public void WriteToLog(string logMessage)
    {
        using (StreamWriter sw = File.CreateText(file))
        {
            sw.WriteLine(DateTime.Now);
            sw.WriteLine($"{logMessage}");
            sw.WriteLine("**************************************************");
        }
    }

    public void WriteToConsole(string optionalMessage = "", int optionalInt = -400, float optionalFloat = -400)
    {
        if (optionalInt == 0 && optionalFloat == 0)
        {
            Debug.Log(optionalMessage);
        }
        if (optionalMessage != "" && optionalInt != -400 && optionalFloat != -400)
        {
            Debug.Log("**************************************************");
            Debug.Log(optionalMessage + " -MESSAGE");
            Debug.Log(optionalInt + " -INT");
            Debug.Log(optionalFloat + " -FLOAT");
            Debug.Log("**************************************************");
        }
        if (optionalMessage != "")
        {
            Debug.Log("**************************************************");
            Debug.Log(optionalMessage + " -MESSAGE");
            Debug.Log("**************************************************");
        }
        if (optionalInt != -400)
        {
            Debug.Log("**************************************************");
            Debug.Log(optionalInt + " -INT");
            Debug.Log("**************************************************");
        }
        if (optionalFloat != -400)
        {
            Debug.Log("**************************************************");
            Debug.Log(optionalFloat + " -FLOAT");
            Debug.Log("**************************************************");
        }
        if (optionalMessage != "" && optionalInt != -400)
        {
            Debug.Log("**************************************************");
            Debug.Log(optionalMessage + " -MESSAGE");
            Debug.Log(optionalInt + " -INT");
            Debug.Log("**************************************************");
        }
        if (optionalMessage != "" && optionalFloat != -400)
        {
            Debug.Log("**************************************************");
            Debug.Log(optionalMessage + " -MESSAGE");
            Debug.Log(optionalFloat + " -FLOAT");
            Debug.Log("**************************************************");
        }
    }
}
