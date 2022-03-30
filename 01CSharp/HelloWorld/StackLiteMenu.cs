namespace StackLite;

public class StackLiteMenu
{
    // method defines a behavior of a class
    public void MainMenu()
    {
        Console.WriteLine("Welcome to StackLite!");

        EnterTitle:
        Console.WriteLine("What brings you here today?");
        string title = Console.ReadLine() ?? "this is default value";
        if(String.IsNullOrWhiteSpace(title)) {
            Console.WriteLine("Your title cannot be empty");
            goto EnterTitle;
        }

        EnterBody:
        Console.WriteLine("Tell us more about your issue");
        string content = Console.ReadLine() ?? "";
        if(String.IsNullOrWhiteSpace(content)) {
            Console.WriteLine("You can't have your body be empty");
            goto EnterBody;
        }

        // Issue newIssue = new Issue();
        // newIssue.Title = title;
        // newIssue.Content = content;
        // newIssue.Score = 0;

        Issue createdIssue = new Issue(title, content);

        Console.WriteLine("You entered " + createdIssue.ToString());
    }
}