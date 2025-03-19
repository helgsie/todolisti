using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

[ApiController]
[Route("api/todo")]
public class TodoController : ControllerBase
{
    private static List<TodoItem> todos = new();

    // GET /api/todo - Skilar öllum to-do verkefnum
    [HttpGet]
    public IEnumerable<TodoItem> GetAll() => todos;

    // POST /api/todo - Býr til nýtt to-do verkefni
    [HttpPost]
    public IActionResult AddTodo(TodoItem item)
    {
        item.Id = todos.Count + 1;
        todos.Add(item);
        return CreatedAtAction(nameof(GetAll), new { id = item.Id }, item);
    }

    // DELETE /api/todo/{id} - Eyðir ákveðnu to-do verkefni
    [HttpDelete("{id}")]
    public IActionResult DeleteToDo(int id)
    {
        var todo = todos.FirstOrDefault();
        if (todo == null) 
        {
            return NotFound(new { message = "To-do verkefni ekki fundið" });
        }

        todos.Remove(todo);
        return NoContent();
    }
}
