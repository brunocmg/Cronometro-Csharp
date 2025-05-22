Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Qual unidade deseja utilizar ?");

    string sData = Console.ReadLine().ToLower();
    char data = sData[0];
    int multiplier = 1;

    if (data == '0')
        Environment.Exit(0);


    Console.WriteLine("Quanto tempo você quer contar ?");
    string sTime = Console.ReadLine();
    int time = int.Parse(sTime);


    if (data == 'm')
        multiplier = 60;

    PreStart(time * multiplier);

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500);

    Menu();
}
