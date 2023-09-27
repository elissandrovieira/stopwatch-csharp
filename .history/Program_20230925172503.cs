// See https://aka.ms/new-console-template for more information

Star

static void Start () {
  var time = 10;
  var currentTime = 0;

  while (currentTime != time) {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
}