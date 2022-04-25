using ServiceStack;
using ToDoApp.ServiceModel;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceInterface;

public class MyServices : Service
{
    public object Any(Test request)
    {
        return new TestResponse { Result = $"Hello, {request.Id}!" };
    }
}