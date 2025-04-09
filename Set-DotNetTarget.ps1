Get-ChildItem -Recurse -Filter *.csproj | ForEach-Object {
    (Get-Content $_.FullName) -replace '<TargetFramework>.*?</TargetFramework>', '<TargetFramework>net9.0</TargetFramework>' | Set-Content $_.FullName
    Write-Host "Updated:" $_.FullName
}