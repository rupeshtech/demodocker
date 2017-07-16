$msBuildPath = "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe"

# publish website:
& $msBuildPath ..\src\DemoDocker\DemoDocker.csproj /p:OutputPath=..\..\Docker\publish  /p:DeployOnBuild=true
