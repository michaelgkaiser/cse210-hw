using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 2019;
    job1._endYear = 2024;

    Job job2 = new Job();
    job2._company = "Hewlett Packard";
    job2._jobTitle = "Camera Engineer";
    job2._startYear = 2017;
    job2._endYear = 2019;

    Job job3 = new Job();
    job3._company = "Samsung";
    job3._jobTitle = "Design Engineer";
    job3._startYear = 2016;
    job3._endYear = 2013;

    Job job4 = new Job();
    job4._company = "Apple";
    job4._jobTitle = "Apple Support Advisor";
    job4._startYear = 2011;
    job4._endYear = 2013;

    Resume myResume = new Resume();
    myResume._name = "Kyle Thatcher";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);
    myResume._jobs.Add(job3);
    myResume._jobs.Add(job4);

    myResume.Display();
    }
}