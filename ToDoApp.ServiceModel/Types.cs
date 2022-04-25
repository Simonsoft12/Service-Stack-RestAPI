using System;
using ServiceStack.DataAnnotations;

namespace ToDoApp.ServiceModel.Types
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Percentage { get; set; }
        public DateTime DateTo { get; set; }
        public bool Done { get; set; }
    }

}