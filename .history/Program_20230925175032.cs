// See https://aka.ms/new-console-template for more information

Start(5);

static void Start (int time) {
  var currentTime = "";
  var seconds = 0;
  var minutes = 0;

  while (seconds != 60) {
    Console.Clear();
    seconds++;
    currentTime = $"{minutes}.{seconds}" ; 
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }

  switch (time) {
  case 5: Minutes(minutes, seconds, currentTime, time); break;
  default: Console.WriteLine(currentTime); break;
 }
  

}

static void Minutes (int minutes, int seconds, string currentTime, int time) {
  
 
Console.Clear();
  minutes++;
  seconds = 0;
  currentTime = $"{minutes}.{seconds}";
  Console.WriteLine(currentTime);
  Thread.Sleep(1000);
  Start(5);
}