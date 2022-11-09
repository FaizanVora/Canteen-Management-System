namespace Canteen_Management_System.Models
{
    public class MailRequest
    {
#pragma warning disable CS8618 // Non-nullable property 'ToEmail' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ToEmail { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ToEmail' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Subject' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Subject { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Subject' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Body' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Body { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Body' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
