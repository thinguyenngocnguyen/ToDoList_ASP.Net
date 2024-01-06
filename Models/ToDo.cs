using System.ComponentModel.DataAnnotations;

/*
 * For a complex type to work with model binding, it must have a default
constructor, and the properties to be bound must be public and writeable.
For example, the ToDo class shown in this figure meets these criteria. 
Although this class doesn’t include a default constructor, which is a constructor without any parameters,
the C# compiler will generate one for you if a class doesn’t include any constructors. In this example, 
the view is strongly typed and uses the asp-for tag helper in the <input> elements to specify the property names of the model object. 
This provides for IntelliSense and compiler checking, which makes it easier and less error prone to enter these property names. Note 
 * */
namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string? StatusId { get; set; }
        public Status? Status { get; set; }

        public bool Overdue => 
            StatusId == "open" && DueDate < DateTime.Today;
    }
}
