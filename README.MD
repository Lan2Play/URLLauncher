# URLLauncher

A Little Software that removes an URL Prefix from the passed url and adds it to the end of the arguments parameter which then gets passed to the destination software. It becomes handy to use custom URL Handlers on windows with software that dont support handling full urls in Parameters.


# Usage
    urllauncher.exe <url> <software to startup> <software to startup args>

# Building

To Build the Software, the Dotnetcore SDK 3..1 is required. https://dotnet.microsoft.com/download

    dotnet.exe publish -c Release -p:PublishSingleFile=true -r win-x64

The single exe file can now be found in bin\Release\netcoreapp3.1\win-x64\publish