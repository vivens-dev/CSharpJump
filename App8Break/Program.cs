for (int i = 9; i >= 0; i--)
{
    if(i == 5) { 
        break;
    }
    
    for (int k = i; k >=0; k--) 
    {  
        if(k == 3) { 
            break; 
        }

        Console.Write(k + " ");
    }
    Console.WriteLine();
}
