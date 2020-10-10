# URLLauncher

A Little software that removes an url prefix from the passed url and adds it to the end of the arguments parameter which then gets passed to the destination software. It becomes handy to use custom url handlers on windows with software that dont support handling full urls in Parameters.


# Usage
    urllauncher.exe <url> <software to startup> <software to startup args>

# Building

To build the software, the dotnetcore SDK 3..1 is required. https://dotnet.microsoft.com/download

    dotnet.exe publish -c Release -p:PublishSingleFile=true -r win-x64

The single exe file can now be found in bin\Release\netcoreapp3.1\win-x64\publish