namespace TaskManager.Models
{
    public class MainTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime? DeadLine { get; set; }
        public virtual ICollection<SubTask> SubTasks { get; set; }
        public MainTask()
        {

        }
    }
}
