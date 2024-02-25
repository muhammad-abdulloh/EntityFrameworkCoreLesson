echo Stopping dotnet1.service
sudo systemctl stop dotnet1.service

echo Changing directory to project
cd ~/dotnetdeploy/EntityFrameworkCoreLesson

echo Git Pulling
git pull

echo Removed old files
sudo rm -rf /var/www/publishdll/*

echo Publishing new app
dotnet publish

echo Copying new files
sudo cp -r EntityFrameworkCoreLesson/bin/Release/net8.0/publish/* /var/www/publishdll/

echo Starting service
sudo systemctl start dotnet1.service
