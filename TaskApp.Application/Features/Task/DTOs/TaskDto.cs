
namespace TaskApp.Application.Features.Task.DTOs
{
	public class TaskDto : BaseDto, ITaskDto
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public bool IsCompleted { get; set; }
		public ChecklistDto? checklists { get; set; }
	}
}