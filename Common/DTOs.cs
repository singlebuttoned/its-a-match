namespace Common;

public class Test
{
    public CodingTask[] CodingTasks;
    public Guid Id;
    public string Name;
    public OpenQuestion[] OpenQuestions;
    public Quiz[] Quizzes;
    public Skill[] Skills;
}

public class Quiz
{
    public ClosedQuestion[] ClosedQuestions;
    public Guid Id;
    public string Name;
}

public class Theory
{
    public Guid Id;
    public Link[] Links;
    public string Name;
    public string Text;
}

public class OpenQuestion
{
    public string DescriptionText;
    public Guid Id;
    public string Name;
}

public class CodingTask
{
    public string DescriptionText;
    public string ExpectedResult;
    public Guid Id;
    public string Language;
    public string Name;
}

public class Skill
{
    public string DescriptionText;
    public Guid Id;
    public string Name;
}

public class Candidate : User
{
    public Link CV;
    public Vacancy[] RepliedVacancies;
    public Skill[] Skills;
    public Vacancy[] Subscriptions;
}

public class Mentor : User
{
    public string Description;
    public Skill[] Skills;
}

public class User
{
    public string Email;
    public Guid Id;
    public string Name;
    public string Phone;
}

public class Vacancy
{
    public string DescriptionText;
    public Guid Id;
    public string Name;
    public Skill[] Skills;
    public Test[] Tests;
}

public class ClosedQuestion
{
    public string[] Answers;
    public int CorrectAnswerIndex;
    public string DescriptionText;
    public Guid Id;
    public string Name;
}

public class Link
{
    private string Name;
    private string Url;
}