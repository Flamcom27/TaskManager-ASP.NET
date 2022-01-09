namespace TaskManager.Models
{
    public class SubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime? DeadLine { get; set; }
        public virtual MainTask MainTask { get; set; }
        public SubTask()
        {

        }
    }
}
