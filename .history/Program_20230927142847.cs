// See https://aka.ms/new-console-template for more information

Menu();

static void Menu () {
  Console.Clear();
  Console.WriteLine("How many minutes you want?");
  Console.WriteLine("S - seconds");
  Console.WriteLine("M - minutes");
  Console.WriteLine("0 - Exit");
  Console.WriteLine("-------------------------------------------");
  
  var currentTime = "";
  var seconds = 0;
  var minutes = 0;
  var data = Console.ReadLine().ToLower();

  if (data == "0") {
    Console.WriteLine("OK!");
    Environment.Exit(0);
  } else {
    Seconds(minutes, seconds, currentTime, data);
  }
}


static void Seconds (int minutes, int seconds,string currentTime, string data) {
  var type = char.Parse(data.Substring(data.Length - 1, 1));
  var time = 0;
  var timeOut = 58;
  var isMinutes = true;
  
  if (type == 's' && time >= 60) 
    time = int.Parse(data.Substring(0, data.Length - 1)) / 60;
  if (type == 'm')
    time = int.Parse(data.Substring(0, data.Length - 1));
   else if (time < 60 && type == 's') {
    timeOut = int.Parse(data.Substring(0, data.Length - 1)) - 1;
    isMinutes = false;
  } else if (
      type == '1' ||
      type == '2' ||
      type == '3' ||
      type == '4' ||
      type == '5' ||
      type == '6' ||
      type == '7' ||
      type == '8' ||
      type == '9'
    ) {
      time = int.Parse(data);
    } else {
      Console.WriteLine("I couldn't understand you. Please tell me again.");
      Thread.Sleep(2500);
      Menu();
  } 
  while (seconds <= timeOut) {
      Console.Clear();
      seconds++;
      currentTime = $"{minutes}.{seconds}" ; 
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);
  }
  
  switch (isMinutes) {
    case true: Minutes(minutes, seconds, currentTime, time, data);break;
    case false: 
      Console.WriteLine("Finish!");
      Thread.Sleep(2500);
      Menu();
    break;
  }
}

static void Minutes (int minutes, int seconds, string currentTime, int time, string data) {
  
  while (minutes != time) {
    Console.Clear();
    minutes++;
    seconds = 0;
    currentTime = $"{minutes}.{seconds}";
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);

    if (minutes == time) {
      Console.WriteLine("Finish!");
      Thread.Sleep(2500);
      Menu();
    } else {
      Seconds(minutes, seconds, currentTime, data);
    }
  }
}
