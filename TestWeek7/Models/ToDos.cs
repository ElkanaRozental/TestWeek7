using System.Runtime.CompilerServices;

namespace TestWeek7.Models
{
    public class ToDos
    {
        List<ToDo>ToDo { get; set; } = new List<ToDo>();
        int ? Total { get; set; } 
        int? Skip { get; set; }
        int Limit { get; set; }

        public ToDos()
        {
            if (ToDo != null)
            {
                Total = ToDo.Count;
            }
        }
    }
    
}
