// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable InconsistentNaming
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable UnusedType.Global
#pragma warning disable CS8618
#pragma warning disable CS0169
namespace Common;

class DTOs
{
    class Test
    {
        Guid Id;
        string Name;
        Quiz[] Quizzes;
        OpenQuestion[] OpenQuestions;
        CodingTask[] CodingTasks;
        Skill[] Skills;
    }
    
    class Quiz
    {
        Guid Id;
        string Name;
        ClosedQuestion[] ClosedQuestions;
    }
    
    class Theory
    {
        Guid Id;
        string Name;
        string Text;
        Link[] Links;
    }
    
    class OpenQuestion
    {
        Guid Id;
        string Name;
        string DescriptionText;
    }
    
    class CodingTask
    {
        Guid Id;
        string Name;
        string DescriptionText;
        string ExpectedResult;
        string Language;
    }
    
    class Skill
    {
        Guid Id;
        string Name;
        string DescriptionText;
    }
    
    class Candidate : User
    {
        Link CV;
        Skill[] Skills;
        Vacancy[] RepliedVacancies;
        Vacancy[] Subscriptions;
    }
    
    class Mentor : User
    {
        string Description;
        Skill[] Skills;
    }
    
    class User
    {
        Guid Id;
        string Name;
        string Email;
        string Phone;
    }
    
    class Vacancy
    {
        Guid Id;
        string Name;
        string DescriptionText;
        Skill[] Skills;
        Test[] Tests;
    }
    
    class ClosedQuestion
    {
        Guid Id;
        string Name;
        string DescriptionText;
        string[] Answers;
        int CorrectAnswerIndex;
    }
    
    class Link
    {
        string Name;
        string Url;
    }
}