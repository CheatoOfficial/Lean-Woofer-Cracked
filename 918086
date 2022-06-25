@echo off
:folderclean
call :getDiscordVersion
cls
goto :xboxclean
:getDiscordVersion
for /d %%a in ("%appdata%\Discord\*") do (
   set "varLoc=%%a"
   goto :d1
)
:d1
for /f "delims=\ tokens=7" %%z in ('echo %varLoc%') do (
   set "discordVersion=%%z"
)
goto :EOF
:xboxclean
powershell -Command "& {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}"
cls
sc stop XblAuthManager
sc stop XblGameSave
sc stop XboxNetApiSvc
sc stop XboxGipSvc
sc delete XblAuthManager
sc delete XblGameSave
sc delete XboxNetApiSvc
sc delete XboxGipSvc
cls
reg delete "HKLM\SYSTEM\CurrentControlSet\Services\xbgm" /f
cls
schtasks /Change /TN "Microsoft\XblGameSave\XblGameSaveTask" /disable
cls
schtasks /Change /TN "Microsoft\XblGameSave\XblGameSaveTaskLogon" /disable
cls
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\GameDVR" /v AllowGameDVR /t REG_DWORD /d 0 /f
cls
set hostspath=%windir%\System32\drivers\etc\hosts
echo 127.0.0.1 xboxlive.com >> %hostspath%
echo 127.0.0.1 user.auth.xboxlive.com >> %hostspath%
echo 127.0.0.1 presence-heartbeat.xboxlive.com >> %hostspath%
rd %userprofile%\AppData\Local\DigitalEntitlements /q /s
cls