﻿// See https://aka.ms/new-console-template for more information

Start(0, 5);

static void Start (int minutes, int time) {
  var currentTime = "";
  var seconds = 0;
  var currentMinutes = minutes;

  while (minutes != time) {
    while (seconds != 3) {
      Console.Clear();
      seconds++;
      currentTime = $"{currentMinutes}.{seconds}" ; 
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);
    }
    Minutes(minutes, seconds, currentTime, time);
  }
}

static void Minutes (int minutes, int seconds, string currentTime, int time) {
  Console.Clear();
  minutes++;
  seconds = 0;
  currentTime = $"{minutes}.{seconds}";
  Console.WriteLine(currentTime);
  Thread.Sleep(1000);
  Start(minutes, time);
}