echo Stopping entity1.service
sudo systemctl stop entity1.service

echo Changing directory to project
cd ~/dotnetfolder/EntityFrameworkCoreLesson

echo Removed old files
sudo rm -rf /var/www/entity1/*

echo Publishing new app
dotnet publish

echo Copying new files
sudo cp -r EntityFrameworkCoreLesson/bin/Release/net8.0/publish/* /var/www/entity1/

echo Starting service
sudo systemctl start entity1.service
