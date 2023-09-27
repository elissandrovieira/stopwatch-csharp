// See https://aka.ms/new-console-template for more information

Start(5);

static void Start (int time) {
  var currentTime = 0;
  var seconds = 0;
  var minutes = 0;

  while (seconds != time) {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
}