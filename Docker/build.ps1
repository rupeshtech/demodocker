$msBuildPath = "C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe"

# publish website:
& $msBuildPath ..\src\DemoDocker\DemoDocker.csproj /p:OutputPath=..\..\Docker\publish  /p:DeployOnBuild=true
