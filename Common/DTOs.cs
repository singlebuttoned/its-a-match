namespace Common;

public class Meta
{
    public string name;
    public Guid id;
    public string description;
    public Meta(string name, Guid id, string description)
    {
        this.id = id;
        this.description = description;
        this.name = name;
    }
}
public class Theory
{
    public Link[] Links;
    public string Text;
    public Meta meta;
}
public interface ITask
    {
        Meta meta { get;set;}
        string ExpectedResult { get;set;}
    }
public class Test
{
    public Meta meta;
    public ITask[] tasks;
    public Skill[] Skills;
}

public class Quiz : ITask
{
    public ClosedQuestion[] ClosedQuestions;
    public Meta meta{get;set;}
    public string ExpectedResult{get;set;}
}
public class OpenQuestion : ITask
{
    public Meta meta {get;set;}
    public string ExpectedResult {get;set;}
}

public class CodingTask : ITask
{
    public string ExpectedResult {get;set;}
    public string Language;
    public Meta meta{get;set;}
}

public class Skill
{
    public Meta meta;
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
    public Meta meta;
    public Skill[] Skills;
    public Test[] Tests;
}

public class ClosedQuestion
{
    public string[] Answers;
    public int CorrectAnswerIndex;
    public Meta meta;
}

public class Link
{
    private string Name;
    private string Url;
}