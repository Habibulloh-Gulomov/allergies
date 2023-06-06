var allergies =  new Dictionary<int, string>()
{
    {1,"egg" },
    {2,"peanuts" },
    {4,"shellfish "},
    {8,"strawberries" },
    {16,"tomatoes" },
    {32,"chocolate" },
    {64,"pollen" },
    {128, "cats" }
};

int allergieScore = Convert.ToInt32(Console.ReadLine());

if (allergieScore > 128)
{
    int result =0;
    result = allergieScore - 128;
    Console.WriteLine(allergies[128]);
    Console.WriteLine(allergies[result]);
}else if(allergieScore > 64)
{
    allergieScore -= 64;
    Console.WriteLine(allergies[64]);
    Console.WriteLine(allergies[allergieScore]);
}else if (allergieScore > 32)
{
    allergieScore -= 32;
    Console.WriteLine(allergies[32]);
    Console.WriteLine(allergies[allergieScore]);
}else if(allergieScore < 16)
{
    allergieScore -= 16;
    Console.WriteLine(allergies[16]);
    Console.WriteLine(allergies[allergieScore]);
}
else if (allergieScore < 8)
{
    allergieScore -= 8;
    Console.WriteLine(allergies[8]);
    Console.WriteLine(allergies[allergieScore]);
}
else if (allergieScore < 4)
{
    allergieScore -= 4;
    Console.WriteLine(allergies[4]);
    Console.WriteLine(allergies[allergieScore]);
}
else if (allergieScore < 2)
{
    allergieScore -= 2;
    Console.WriteLine(allergies[2]);
    Console.WriteLine(allergies[allergieScore]);
}
else if (allergieScore < 1)
{
    allergieScore -= 1;
    Console.WriteLine(allergies[1]);
    Console.WriteLine(allergies[allergieScore]);
}
else
{
    Console.WriteLine(allergies[1]);
}