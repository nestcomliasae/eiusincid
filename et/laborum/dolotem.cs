// Assuming 'example' is an instance of a example client and 'commitData' is a Tuple with commit details
try
{
    // Construct a more descriptive commit message
    string commitMessage = $"Update by {name}: {commitData.Item2}";

    // Create a commit on the 'main' branch using the provided repository, name, and commit data
    await example.CreateCommit(repo, "main", commitMessage, commitData.Item1, "");

    Console.WriteLine("Commit created successfully.");
}
catch (Exception ex)
{
    // Log the exception details for debugging purposes
    Console.WriteLine($"Failed to create commit: {ex.Message}");
}
