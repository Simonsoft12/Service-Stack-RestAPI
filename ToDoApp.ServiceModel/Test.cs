using ServiceStack;
using System;

namespace ToDoApp.ServiceModel;

public class Test : IReturn<TestResponse>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Percentage { get; set; }
    public DateTime DateTo { get; set; }
    public int Done { get; set; }
}

public class TestResponse
{
    public string Result { get; set; }
}
