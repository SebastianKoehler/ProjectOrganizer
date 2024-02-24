@echo off
cls

REM Testen, ob der dotnet-Befehl verf�gbar ist
dotnet --version > nul 2>&1
if %errorlevel% neq 0 (
    echo Bitte installiere dotnet f�r die Verwendung dieses Skripts.
    pause
    exit /b 1
)

REM Ausf�hren der dotnet-Befehle...
dotnet add package Microsoft.AspNetCore.App
dotnet add package Microsoft.AspNetCore.Mvc.Core
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet tool install --global dotnet-ef

REM �berpr�fen der NuGet-Pakete...
dotnet restore

REM Create a new migration and update the new database
REM dotnet ef migrations add InitialCreate
REM dotnet ef database update

echo Fertig.
pause
