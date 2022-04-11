Steps to deploy on your machine:

	1. Copy CoreAddIn.Inventor.addin to: "C:\ProgramData\Autodesk\Inventor Addins\"

	2. Make a new folder at: "C:\ProgramData\Autodesk\Inventor Addins\CoreAddIn\"

	3. Clone solution from github

	4. Clean solution

	5. Rebuild solution

	6. Move everything from output dir to "C:\ProgramData\Autodesk\Inventor Addins\CoreAddIn\"

	7. You should end up with "C:\ProgramData\Autodesk\Inventor Addins\CoreAddIn\CoreAddIn.dll" as a valid, existing file path

	8. Rename CoreAddIn.X.manifest to CoreAddIn.dll.manifest (It should be in the same dir as CoreAddIn.dll

	9. Go into the Resources folder and move Microsoft.VisualStudio.Interop.dll to "C:\ProgramData\Autodesk\Inventor Addins\CoreAddIn\"