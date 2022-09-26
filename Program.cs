Console.WriteLine("*********************************\n");


Console.WriteLine("Random Array:\n");

static int[] RandomArray(){
    Random rand = new Random();
    int[] randArr = new int[10];
    int min = 0, max = 0, sum = 0;
    for(int i = 0; i < randArr.Length; i++){
        randArr[i] = rand.Next(5, 26);
        sum += randArr[i];
        min = randArr[0];
        max = randArr[0];

        if(min > randArr[i]){
            min = randArr[i];
        }
        if(max < randArr[i]){
            max = randArr[i];
        }
    }
    Console.WriteLine($"{min}\n{max}\n{sum}");
    
    return randArr;
};

RandomArray();

Console.WriteLine("\n*********************************\n");


Console.WriteLine("Coin Flip:\n");

static string TossCoin(){
    Console.WriteLine("Tossing a Coin!");

    Random rand = new Random();
    string h = "Heads", t = "Tails", result;
    int flip = rand.Next(10);

    if(flip % 2 == 0){
        result = h;
    }else{
        result = t;
    }

    Console.WriteLine($"The coin landed on {result}!");
    return result;
};

TossCoin();

Console.WriteLine("\n---------------------------------\n");

static double TossMultipleCoins(int y){
    Console.WriteLine("Tossing Multiple Coins!");

    Random rand = new Random();
    string h = "Heads", t = "Tails";
    double headCount = 0;
    for(int i = 1; i <= y; i++){
        int flip = rand.Next(10);
        if(flip % 2 == 0){
            Console.WriteLine(h);
            headCount++;
        }else{
            Console.WriteLine(t);
        }
    }
    Console.WriteLine(headCount);
    Console.WriteLine(y);
    double result = (headCount / y) * 100;

    Console.WriteLine($"You got Heads {result}% of the time!");
    return result;
};

TossMultipleCoins(5);

Console.WriteLine("\n*********************************\n");


Console.WriteLine("Names:\n");

static List<string> Names(){
    List<string> newList = new List<string>();
    List<string> shuffled = new List<string>();
    List<string> nameList = new List<string>();

    nameList.Add("Todd");
    nameList.Add("Tiffany");
    nameList.Add("Charlie");
    nameList.Add("Geneva");
    nameList.Add("Sydney");

    Console.WriteLine("New List");
    foreach(string name in nameList){
        if(name.Length > 5){
            newList.Add(name);
            Console.WriteLine(newList[newList.IndexOf(name)]);
        }
    }

    Console.WriteLine("\nShuffled New List");

    for(int i = 0; i < newList.Count; i++){
        if(i == 0){
            shuffled.Insert(i, newList[newList.Count - 1]);
        }else{
            shuffled.Insert(i, newList[i - 1]);
        }
        Console.WriteLine(shuffled[i]);
    }
    return newList;
};

Names();

Console.WriteLine("\n*********************************");