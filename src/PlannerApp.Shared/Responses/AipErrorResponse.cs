namespace PlannerApp.Shared.Responses
{
    public class AipErrorResponse
    {
        public string Message { get; set; }
        public string[] Errors { get; set; }
        public bool IsSuccess { get; set; }
    }
}
