$nugetCLI = "./nuget.exe" 
$msbuild = "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe"

if (!(Test-Path $nugetCLI)) {
    Invoke-WebRequest -Uri https://dist.nuget.org/win-x86-commandline/latest/nuget.exe -OutFile $nugetCLI
}

& $msbuild ..\Itenso.RtfParser.sln /m:4 /nodeReuse:false /p:Configuration=Release /p:Platform="AnyCPU" /t:Rebuild

.\nuget.exe pack .\Itenso.RtfParser.nuspec