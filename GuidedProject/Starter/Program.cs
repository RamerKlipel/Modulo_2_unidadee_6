int currentAssignments = 5;

int[] sophia = [90, 86, 87, 98, 100];
int[] andrew = [92, 89, 81, 96, 90];
int[] emma = [90, 85, 87, 98, 68];
int[] logan = [90, 95, 87, 88, 96];

string[] studentNames = ["Sophia", "Andrew", "Emma", "logan"];
int [] studentScores = new int[10];

foreach (var name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophia;
    
    else if (currentStudent == "Andrew")
        studentScores = andrew;

    else if (currentStudent == "Emma")
        studentScores = emma;

    else if (currentStudent == "Logan")
        studentScores = logan;

    int sophiaSum = 0;

    decimal sophiaScore;

    foreach (int score in sophia)
    {
        sophiaSum += score;
        
    }

    sophiaScore = (decimal)sophiaSum / currentAssignments;

    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
