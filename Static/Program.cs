// See https://aka.ms/new-console-template for more information
using static System.Console;
Person Morgo = new(49, "female");
Person Bill = new(53, "male");
Morgo.CheckAge();
Bill.CheckAge();
class Person
{
    static int retirementAgeM = 65;
    static int retirementAgeW = 55;
    bool gender;
    int age;
    public void SetAge(int age)
    {
        this.age = age;
    }
    //public int Age()
    //{
    //    return age;
    //}
    public void SetGender(string gender)
    {
        if (gender == "female"||gender=="woman") this.gender = true;
        else this.gender = false;
    }
    //public bool Gender()
    //{
    //    return gender;
    //}
    public Person(int age, string gender)
    {
        SetAge(age);
        SetGender(gender);
    }
    public void CheckAge()
    {
        if (gender == true)
            if (age >= retirementAgeW)
                WriteLine("Уже на пенсии");
            else
                WriteLine($"Сколько лет осталось до пенсии: {retirementAgeW - age}");
        else
            if (age >= retirementAgeM)
            WriteLine("Уже на пенсии");
        else
            WriteLine($"Сколько лет осталось до пенсии: {retirementAgeM - age}");
    }
}