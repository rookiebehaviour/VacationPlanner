namespace BlazorApp.Data
{
    public class TodoService
    {
        private List<TodoItem> todos = new List<TodoItem>();

        public IReadOnlyList<TodoItem> Todos => todos;

        public void AddTodoItem(TodoItem item)
        {
            todos.Add(item);
        }
    }
}
