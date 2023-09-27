// See https://aka.ms/new-console-template for more information

Start(5);

static void Start (int time) {
  var currentTime = 0;
  var miliseconds = 0;
  

  while (currentTime != time) {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
}