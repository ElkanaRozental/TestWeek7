namespace TestWeek7.Models
{
    public class ToDo
    {
        int Id { get; set; }
        string ThingToDo { get; set; }
        bool IsCompleted { get; set; }  
        int UserId {  get; set; }
    }
}
