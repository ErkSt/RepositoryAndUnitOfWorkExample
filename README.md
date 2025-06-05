# RepositoryAndUnitOfWorkExample
Small example of implementation of Repository and Unit of Work Pattern

It works with an SQL Server database mounted on docker:
https://hub.docker.com/r/microsoft/mssql-server/

To mount it just run the command:

docker pull mcr.microsoft.com/mssql/server

and 

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest

remember to check on the password and port. 

And replace the connection string on appSettings.json
