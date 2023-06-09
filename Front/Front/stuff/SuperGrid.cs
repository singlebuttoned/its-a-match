using System.Text.RegularExpressions;
using Avalonia.Controls;
using Avalonia.Markup.Parsers;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Converters;
using Avalonia.Markup.Xaml.MarkupExtensions;

namespace Front.stuff;

public class SuperGrid : Grid
{
    public RowDefinitions SuperRowDefinitions
    {
        get => RowDefinitions;
        set => RowDefinitions = value;
    }
}

public class SuperRowDefinitions : RowDefinitions
{
    public SuperRowDefinitions(string s) : base(Convert(s))
    {
    }

    //converts SuperGrid definition to a standard one
    //standard definition example: "1*,2*,3*", "1*,Auto,3*", "1*,Auto,10"
    //definition is a string of values separated by commas (,)
    //values can be numbers or "Auto" or "*" or "n*" where n is a number
    //this conversion is implemented by constructor of RowDefinitions
    //
    //SuperGrid also supports usage of StaticResource values
    //example: "1*,2*,3*,{StaticResource RowWidth1}"
    //this conversion is implemented by Convert method
    //it parses the string and replaces StaticResource values with their values
    private static string Convert(string s)
    {
        //parse the string, get a list of values, find StaticResource values, replace them with their values
        //parse string with System.String methods
        //split string by commas (,)
        var values = s.Split(',');
        //iterate through values
        for (var i = 0; i < values.Length; i++)
        {
            
        }

        //using System.String methods
        string GetStaticResourceValue1(string s)
        {
            //if value is a StaticResource value
            if (s.Contains("{StaticResource"))
            {
                //get the name of the StaticResource
                var name = s.Split('{', '}')[1].Split(' ')[1];
                //explanation:
                //values[i] = "{StaticResource RowWidth1}"
                //values[i].Split('{', '}') = ["", "StaticResource RowWidth1", ""]
                //values[i].Split('{', '}')[1].Split(' ') = ["StaticResource", "RowWidth1"]
                //values[i].Split('{', '}')[1].Split(' ')[1] = "RowWidth1"
                //get the value of the StaticResource
                var value = new StaticResourceExtension(name).ProvideValue(null);
                //replace the value with its value
                return value.ToString();
            }

            return null;
        }
        
        //using regex
        string GetStaticResourceValue2(string s)
        {
            //if value is a StaticResource value
            if (s.Contains("{StaticResource"))
            {
                //get the name of the StaticResource
                var name = Regex.Match(s, @"{StaticResource\s+(?<name>\w+)}").Groups["name"].Value;
                //explanation:
                //values[i] = "{StaticResource RowWidth1}"
                //Regex.Match(values[i], @"{StaticResource\s+(?<name>\w+)}") = "{StaticResource RowWidth1}"
                //Regex.Match(values[i], @"{StaticResource\s+(?<name>\w+)}").Groups["name"] = "RowWidth1"
                //get the value of the StaticResource
                var value = new StaticResourceExtension(name).ProvideValue(null);
                //replace the value with its value
                return value.ToString();
            }

            return null!;
        }

        return null!;
    }
}