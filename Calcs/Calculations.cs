using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcs
{
    public class Calculations
    {
        //calculates total self-study hours
        public static int selfStudyHoursCalc(int numOfCredits, int classHours, int numOfWeeks)
        {
            return ((numOfCredits * 10) / numOfWeeks) - classHours;
        }

        //calculates remaining self-study hours
        public static int remainingSelfStudyHours(int numOfHours, int selfStudyHours)
        {
            return (selfStudyHours - numOfHours);
        }

        //displays remainig self study hours
        public static string displaySelfStudy(DateTime StudyDate, int HoursSpentStudying
            , int SelfStudyHoursPerWeek, int RemainingSelfStudyHours, string ModuleName)
        {
            return "You have studied " + ModuleName + " on the " + StudyDate + " for " + HoursSpentStudying + " hours."
                + "\nFor " + ModuleName + " you have a total of " + SelfStudyHoursPerWeek + " hours of self studying to do." +
                "\nAfter studying you now have " + RemainingSelfStudyHours + " hours left of studying to do.";
        }
    }

}
