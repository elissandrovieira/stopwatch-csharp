// See https://aka.ms/new-console-template for more information

Start(0, 5);

static void Start (int currentMinutes, int time) {
  var currentTime = "";
  var seconds = 0;
  var minutes = currentMinutes;

  while (minutes != time) {
    Seconds(minutes, seconds, current)
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

static void Seconds (int minutes, int seconds,string currentTime, int time) {
  while (seconds != 3) {
      Console.Clear();
      seconds++;
      currentTime = $"{minutes}.{seconds}" ; 
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);
  }
}