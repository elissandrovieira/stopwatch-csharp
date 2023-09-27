// See https://aka.ms/new-console-template for more information

Start(5);

static void Start (int time) {
  var currentTime = 0;
  var seconds = 0;
  var minutes = 0;

  while (seconds != 60) {
    Console.Clear();
    seconds++;
    currentTime = "asd" + 2;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
}