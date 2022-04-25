using ServiceStack;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todo", "GET")]
    [Route("/todo/{Id}", "GET")]
    public class GetSpecificTodo
        : QueryDb<Todo>, IReturn<QueryResponse<Todo>>, IGet
    {
        [Validate("InclusiveBetween(0, 100)")]
        public int? Id { get; set; }
    }

}

