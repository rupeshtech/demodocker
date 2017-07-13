FROM microsoft/windowsservercore
SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

RUN Set-ItemProperty -path 'HKLM:\SYSTEM\CurrentControlSet\Services\Dnscache\Parameters' -Name ServerPriorityTimeLimit -Value 0 -Type DWord
RUN Add-WindowsFeature Web-server, NET-Framework-45-ASPNET, Web-Asp-Net45;     Remove-Website -Name 'Default Web Site'
    
COPY publish  /DemoDocker
RUN New-Website -Name 'DemoDocker' -PhysicalPath 'C:\DemoDocker' -Port 80 -Force

EXPOSE 80

COPY ServiceMonitor.exe /
COPY startup.ps1 /
ENTRYPOINT ./startup.ps1