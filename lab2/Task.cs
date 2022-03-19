namespace lab2
{
     class Task
    {
        private string name;
        private TaskStatus status;

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }
    }
}