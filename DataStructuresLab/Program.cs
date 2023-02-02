





Console.WriteLine("Please enter input to be reversed");
string Input = Console.ReadLine();


Console.WriteLine(ReverseMethod(Input));

static string ReverseMethod(string _input)
{
    Stack<char> MyStack = new Stack<char>();

    foreach(char c in _input)
    {
        MyStack.Push(c);
    }

    string ReversedWord = "";

    foreach(char c in MyStack)
    {
        ReversedWord += c;
    }

    return ReversedWord; 
}