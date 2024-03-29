﻿namespace Implementation.Solutions;

public class GradingStudents
{
    /// <param name="grades"> the grades before rounding </param>
    /// <returns> the grades after rounding as appropriate </returns>
    public static List<int> Run(List<int> grades)
    {
        int roundedNote = 0;
        int increaseNote = 0;

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] <= 35)
                continue;

            roundedNote = 5 * (int)Math.Round(grades[i] / 5.0);
            if (grades[i] < roundedNote)
            {
                increaseNote = roundedNote - grades[i];
                grades[i] += increaseNote;
            }
        }
        return grades;
    }
}

