using ServiceStack;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todos/{Id}", "DELETE")]
    public class DeleteTodo
        : IReturn<IdResponse>, IDelete, IDeleteDb<Todo>
    {
        [Validate("InclusiveBetween(0, 100)")]
        public int Id { get; set; }
    }

}