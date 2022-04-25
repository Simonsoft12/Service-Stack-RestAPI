using System;
using ServiceStack;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todo/{Id}", "PUT")]
    public class SetTodoPercentageComplete
        : IReturn<IdResponse>, IPut, IUpdateDb<Todo>
    {
        [Validate("InclusiveBetween(0, 100)")]
        public int Id { get; set; }
        [Validate("InclusiveBetween(0, 100)")]
        public int Percentage { get; set; }
    }

}