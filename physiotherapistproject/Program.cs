using physiotherapistproject;
using physiotherapistproject.Repo;

PhysioTherapist hanna = new PhysioTherapist
{
    Name = "Hajlító Hanna",
    Bonus = 7000,
    Gender = "nő",
    WorkedDays = 10
};

PhysioTherapist erno = new PhysioTherapist
{
    Name = "Erőskezű Ernő",
    Bonus = 6000,
    Gender = "férfi",
    WorkedDays = 10
};

Console.WriteLine(hanna);
Console.WriteLine(erno);
Console.WriteLine(hanna.whoHasHigherBonus(erno));

PhysioTherapistRepo repo = new();
Console.WriteLine(repo.MostPayedPhysioTherapist());

