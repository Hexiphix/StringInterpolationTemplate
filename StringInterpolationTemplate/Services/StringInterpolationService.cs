using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var answer = _date.Now.ToString("yyyy.MM.dd");
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {
        var answer = _date.Now.ToString("'Day 'dd' of 'MMMM', 'yyyy");
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var answer = _date.Now.ToString("'Year: 'yyyy', Month: 'MM', Day: 'dd");
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var date = _date.Now.ToString("dddd");
        var answer = $"{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var time = _date.Now.ToString("hh:mm tt");
        var date = _date.Now.ToString("dddd");
        var answer = $"{time,10}{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var answer = _date.Now.ToString("'h:'hh', m:'mm', s:'ss");
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var answer = _date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:n3}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        //var date = _date.Now.ToString("yyyy");
        var date = DateTime.Now.ToString("yyyy");
        var year = int.Parse(date);
        var answer = year.ToString("X");
        Console.WriteLine(answer);

        return answer;
    }

    //2.2019.01.22
}
