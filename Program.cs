Queue<int> input = new(Console.ReadLine().Split().Select(int.Parse));

while (input.Any())
{
    Console.WriteLine(Out(input.Peek()));

    input.Dequeue();
}

static string Out(int fb)
{
    if (fb % 15 == 0) {
        return ("fizzbuzz");
    }
    else if (fb % 3 == 0) {
        return "fizz";
    }
    else if (fb % 5 == 0) {
        return "buzz";
    }
    
    return fb.ToString();
}