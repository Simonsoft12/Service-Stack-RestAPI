using System;
using System.ComponentModel.DataAnnotations;
using ServiceStack;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todos/{Id}", "PUT")]
    public class UpdateTodo
        : IReturn<IdResponse>, IPut, IUpdateDb<Todo>
    {
        [Validate("InclusiveBetween(0, 100)")]
        public int Id { get; set; }
        [Validate("RegularExpression('^[a-z]*$')")]
        [StringLength(45)]
        public string Title { get; set; }
        [Validate("RegularExpression('^[a-z]*$')")]
        [StringLength(155)]
        public string Description { get; set; }
        [Validate("InclusiveBetween(0, 100)")]
        public int Percentage { get; set; }
        public DateTime DateTo { get; set; }
        [Validate("InclusiveBetween(0, 1)")]
        public int Done { get; set; }
    }

}