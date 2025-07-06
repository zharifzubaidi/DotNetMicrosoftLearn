// Guided Project Students Marking
/*
    This is C# console application for:
    - processing student name and scores and generate a finalised result report
*/

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Ayra", "Jacob", "Frank", "Emma" };

float[] sophiaResult = new float[] { 90.45f, 86.89f, 87.80f, 98.25f, 100.00f, 94.35f, 90.65f };
float[] ayraResult = new float[] { 92.45f, 89.80f, 81.35f, 96.65f, 90.35f, 89.65f };
float[] jacobResult = new float[] { 90.25f, 85.80f, 87.45f, 98.35f, 68.89f, 89.80f, 70.25f, 89.89f };
float[] frankResult = new float[] { 90.25f, 95.35f, 87.89f, 88.45f, 96.65f, 96.65f };
float[] emmaResult = new float[] { 70.58f, 50.30f, 87.35f, 40.50f, 30.70f, 96.45f, 80.45f };

float[] studentResults = new float[10];

string currentStudentLetterGrade = "";

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentResults = sophiaResult;
    }
    else if (currentStudent == "Ayra")
    {
        studentResults = ayraResult;
    }
    else if (currentStudent == "Jacob")
    {
        studentResults = jacobResult;
    }
    else if (currentStudent == "Frank")
    {
        studentResults = frankResult;
    }
    else if (currentStudent == "Emma")
    {
        studentResults = emmaResult;
    }

    float sumAssignmentScores = 0.00f;
    float currentStudentGrade = 0.00f;
    int gradeAssignments = 0;

    foreach (int score in studentResults)
    {
        gradeAssignments += 1;

        if (gradeAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10.00f;
        }
    }

    currentStudentGrade = sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97.00f)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93.00f)
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade >= 90.00f)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87.00f)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade >= 83.00f)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80.00f)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77.00f)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73.00f)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70.00f)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67.00f)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63.00f)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60.00f)
    {
        currentStudentLetterGrade = "D-";
    }
    else
    {
        currentStudentLetterGrade = "F";
    }

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("\n\nPress the Enter key to continue");
Console.ReadLine();