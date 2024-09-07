# Useful Tips

## links

${userHome} - the path of the user's home folder

${workspaceFolder} - the path of the folder opened in VS Code

[VS Code Variables Reference](https://code.visualstudio.com/docs/editor/variables-reference)

[Visual Studio macros](https://learn.microsoft.com/en-us/visualstudio/ide/reference/pre-build-event-post-build-event-command-line-dialog-box?view=vs-2019)

## xcopy

Perform an Initial full copy preserving permissions
Code (double click to select all for copy):

`xcopy "C:\Source Folder" "\\Destination Server\Share\Folder" /X /H /E /V`
Copy files or folders that have changed since the initial copy
Code (double click to select all for copy):

`xcopy "C:\Source Folder" "\\Destination Server\Share\Folder" /X /H /E /V /D /Y`
Switch Explanation
/X – Copies file audit settings and file ownership and ACL information.
/H – Copies hidden and system files.
/E – Copies directories and subdirectories, including empty ones.
/V – Verifies each new file.
/D – Copies files changed on or after the specified date (D:m-d-y).If no date is given, copies only those files whose source time is newer than the destination time.
/Y – Suppresses prompting to confirm you want to overwrite an existing destination file.