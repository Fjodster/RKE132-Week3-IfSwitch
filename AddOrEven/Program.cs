Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paaris voi paaritu

int result = userNum % 2;

if(result != 0) // 1= ei ole vordne
{
    Console.WriteLine("userNum number is odd.");
}
else
{
    Console.WriteLine("User number is even");
}