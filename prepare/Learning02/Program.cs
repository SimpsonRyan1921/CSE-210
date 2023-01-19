using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Lifeguard";
        job1._company = "Blueray";
        job1._startYear = 2015 ;
        job1._endYear = 2017 ;


        Job job2 = new Job();

        job2._jobTitle = "Audio/Video/Lighting Utility";
        job2._company = "Showpro";
        job2._startYear = 2018 ;
        job2._endYear = 2023 ;

        Resmue myResume = new Resmue();
        myResume._name = "Ryan Simpson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
       
    }
}