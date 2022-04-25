using ServiceStack;
using System;
using System.Runtime.Serialization;
using ToDoApp.ServiceModel.Types;

namespace ToDoApp.ServiceModel
{
    [Route("/todo/incoming", "GET")]
    [Route("/todo/incoming/{DateTo}", "GET")]
    public class GetIncomingTodo
        : QueryDb<Todo>, IReturn<QueryResponse<Todo>>, IGet
    {
        [QueryDbField(Operand = "<=")]
        public DateTime DateTo { get; set; }

    }

}

