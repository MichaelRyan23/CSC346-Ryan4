﻿/********************************************************************
*** NAME :          Michael Ryan
*** CLASS :         CSc 346
*** ASSIGNMENT :    4
*** DUE DATE :      4/5/2024
*** INSTRUCTOR :    GAMRADT 
*********************************************************************
*** DESCRIPTION : This assignment simulates a video game vending machine
*** that allows users to pick 2 different types of consoles. The user is
*** prompted with a menu that leads to several method calls with data 
*** manipulation/user interface abilities. 
********************************************************************/
using System;
using System.Collections.Generic;
using StoreNS;

bool exit = false;
Switch nintendoSwitch = new Switch();
PS5 ps5 = new PS5();

while (!exit) {
    WriteLine("\nWelcome to the Game Store!");
    WriteLine("Please select a system");
    WriteLine("1. PS5");
    WriteLine("2. Switch");
    WriteLine("3. Exit");

    Write("Enter your choice (1-3): ");
    if (int.TryParse(Console.ReadLine(), out int choice)) {
        switch (choice) {
            case 1:
                ps5.Start();
                break;
            case 2:
                nintendoSwitch.Start();
                break;
            case 3:
                exit = true;
                WriteLine("\nThank you for shoppin with us!");
                break;
            default:
                WriteLine("\nInvalid input, try again!\n");
                break;
        }
    }
    else {
        WriteLine("\nInvalid input. Options are 1 -3.\n");
    }
}