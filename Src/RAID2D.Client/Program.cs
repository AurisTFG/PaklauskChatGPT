﻿global using RAID2D.Client.Properties;
global using Timer = System.Windows.Forms.Timer;

[STAThread]
static void Main()
{
    ApplicationConfiguration.Initialize();
    Control.CheckForIllegalCrossThreadCalls = true;

    RAID2D.Client.Managers.ConsoleManager.SpawnConsole();

    Application.Run(new RAID2D.Client.MainForm());
}

Main();