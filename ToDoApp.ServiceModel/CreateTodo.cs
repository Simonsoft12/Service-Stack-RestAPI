using System;
using System.ComponentModel.DataAnnotations;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todos", "POST")]
    public class CreateTodo
        : IReturn<IdResponse>, IPost, ICreateDb<Todo>
    {
        [Validate("InclusiveBetween(0, 100)")]
        public int Id { get; set; }
        [Validate("RegularExpression('^[a-z]*$')")]
        [ServiceStack.DataAnnotations.StringLength(45)]
        public string Title { get; set; }
        [Validate("RegularExpression('^[a-z]*$')")]
        [ServiceStack.DataAnnotations.StringLength(155)]
        public string Description { get; set; }
        [Validate("InclusiveBetween(0, 100)")]
        public int Percentage { get; set; }
        public DateTime DateTo { get; set; }
        [Validate("InclusiveBetween(0, 1)")]
        public int Done { get; set; }
    }

}