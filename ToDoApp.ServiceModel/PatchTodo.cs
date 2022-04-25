using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ToDoApp.ServiceModel.Types;
using ToDoApp.ServiceModel;

namespace ToDoApp.ServiceModel
{
    [Route("/todos/{Id}", "PATCH")]
    public class PatchTodo
        : IReturn<IdResponse>, IPatch, IPatchDb<Todo>
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