# TestKafkaDemo

## Start Kafka
  - In command prompt:
    - cd %ZOOKEEPER_HOME%\bin
    - zkserver
  - In Powershell 
    - cd C:\Tools\kafka
    - .\bin\windows\kafka-server-start.bat .\config\server.properties
    
  - Notes:
    - While installing recieved an error for "path too long". Had to change the directory name tp just C:\Tools\Kafka and remove the version
    - The Kafka project (nuget package) is using a different net framework. If you continue to recieve a warning issue the following command as the nuget command line:
        - Update-Package -Reinstall
  
