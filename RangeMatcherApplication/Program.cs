Random random = new Random();
int daysUntilExpiration = random.Next(12);

// Your code goes here
string expiresIn10Days = "Your subscription will expire soon. Renew now!";
string expiresIn5Days = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!";
string expiresIn1Day = "Your subscription expires within a day!\nRenew now and save 20%!";
string status = "Your subscription has expired.";

if (daysUntilExpiration == 0)
    Console.WriteLine(status);
else if (daysUntilExpiration == 1)
{
    status = expiresIn1Day;
    Console.WriteLine(status);
}
else if (daysUntilExpiration <= 5)
{
    status = expiresIn5Days;
    Console.WriteLine(status);
}
else if (daysUntilExpiration <= 10)
{
    status = expiresIn10Days;
    Console.WriteLine(status);
}
else
    Console.WriteLine(" ");
