int[] grades = { 900, 20, 12, 41}; // The actual size of the array is going to be determined by the number of the elements we put inside
Console.WriteLine(grades[0]); // Be care to not go outside the bounds of the array

int size = Convert.ToInt32(Console.In.ReadLine());
int[] scores = new int[size];

for (int i = 0; i < scores.Length; i++)
{
    scores[i] = Convert.ToInt32(Console.In.ReadLine());

}

for (int i = 0; i < scores.Length; i++)
{
   Console.Write(scores[i] + " ");
}