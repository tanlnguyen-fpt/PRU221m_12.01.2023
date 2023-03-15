StreamWriter? output = null;
try
{
    output = File.CreateText("SampleText.txt");

    // write a few lines
    output.WriteLine("Line 1");
    output.WriteLine("Line 2");
    output.WriteLine("Line 3");
    output.WriteLine("Line 4");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    if (output != null)
    {
        output.Close();
    }
}


StreamReader? input = null;
try
{

    input = File.OpenText("SampleText.txt");

    string line = input.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
        line = input.ReadLine();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    if (input != null)
    {
        input.Close();
    }
}