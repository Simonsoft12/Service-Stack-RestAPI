using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ServiceStack;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todo/{Id}", "PUT")]
    public class MarkTodoAsDone
        : IReturn<IdResponse>, IPut, IUpdateDb<Todo>
    {
        [Validate("InclusiveBetween(0, 100)")]
        public int Id { get; set; }
        [ValidateEqual(1)]
        public int Done { get; set; }
    }

}