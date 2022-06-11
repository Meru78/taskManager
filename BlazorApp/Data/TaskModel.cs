namespace BlazorApp.Data
{
    public class TaskModel
    {
        public int Id {get; set;}        
        public String Detail { get; set; }
        public DateTime DateTime { get; set; }
        public TaskStatuses Status { get; set; }

    }

    public enum TaskStatuses
    {
        ToDo,
        Started,
        Done
    }
}
