using ServiceStack;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todos", "GET")]
    [Route("/todos/{Id}", "GET")]
    public class GetAllTodos
        : QueryDb<Todo>, IReturn<QueryResponse<Todo>>, IGet
    {
    }

}

