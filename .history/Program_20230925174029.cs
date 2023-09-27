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

  while (seconds == 60) {
    Console.Clear();
    minutes++;
    currentTime = $"{minutes}.0";
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
}