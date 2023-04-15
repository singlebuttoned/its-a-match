using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI
{
    public class Meta
    {
        string name {public get; set;}
        int id {public get;set;}
        string description {public get;set;}
        public Meta(string name, int id, string description)
        {
            this.id = id;
            this.description = description;
            this.name = name;
        }
    }
    public interface ITask
    {
        Meta meta {public get; set;}
        string ExpectedResult {public get;set;}
    }

    public class Quiz : ITask
    {

    }
    public class OpenQuestion : ITask
    {

    }
    public class CodingTask : ITask
    {
        
    }
    public class Test
    {
        Meta meta {public get;set;}
        Task[] tasks {public get;set;}
    }
    public class Solution
    {
        Task task {public get;set;}
        string result {public get;set;}
    }
    public class APIMethods
    {
        string GetDefaultCode(string lang)
        {

        }
        Test GetTestById(int id)
        {

        }
        bool SolutionRequest(Solution solution)
        {

        }
    }
}