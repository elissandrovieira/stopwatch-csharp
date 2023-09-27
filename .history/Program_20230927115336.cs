﻿// See https://aka.ms/new-console-template for more information

Menu();

static void Menu () {
  Console.Clear();
  Console.WriteLine("How many minutes you want?");
  Console.WriteLine("S - seconds");
  Console.WriteLine("M - minutes");
  Console.WriteLine("0 - Exit");
  Console.WriteLine("-------------------------------------------");
  var data = int.Parse(Console.ReadLine());
  Start(0, data);
}

static void Start (int currentMinutes, int data) {
  var currentTime = "";
  var seconds = 0;
  var minutes = currentMinutes;

  switch (data) {
    case 0: Console.WriteLine("OK!"); break;
    default: Seconds(minutes, seconds, currentTime, data); break;
  }
}

static void Minutes (int minutes, int seconds, string currentTime, int data) {
  
  while (minutes != data) {
    Console.Clear();
    minutes++;
    seconds = 0;
    currentTime = $"{minutes}.{seconds}";
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);

    if (minutes == data) {
      Console.WriteLine("Finish!");
      Thread.Sleep(2500);
      Menu();
    } else {
      Seconds(minutes, seconds, currentTime, data);
    }
  }
}

static void Seconds (int minutes, int seconds,string currentTime, int data) {
  var = char.Parse()

  while (seconds != 59) {
      Console.Clear();
      seconds++;
      currentTime = $"{minutes}.{seconds}" ; 
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);
  }
  Minutes(minutes, seconds, currentTime, data);
}