using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        StationaryBicycles cyclingActivity = new StationaryBicycles("03 Nov 2022", 30, 12.0);
        Swimming swimmingActivity = new Swimming("03 Nov 2022", 30, 20);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}