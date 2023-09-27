// See https://aka.ms/new-console-template for more information

Start();

static void Start (int ) {
  var currentTime = 0;

  while (currentTime != time) {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
}