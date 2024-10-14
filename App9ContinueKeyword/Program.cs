for (int i = 9; i >= 0; i--)
{
    if(i == 8) {
        continue;
    }

    for (int k = i; k >= 0; k--)
    {
        if(k == 3) { 
            continue;
        }

        Console.Write(k + " ");
    }

    Console.WriteLine();
}