A simple demo application for RavenDB (console mode and embedded for unit testing)

To compile you will need the NuGet packages, they are not on GiHub so you will have enable the package restore option in VS
http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages

Also you need to download the Server files via Nuget or the official site
http://ravendb.net/docs/intro/quickstart/adding-ravendb-to-your-application

To start the server you can edit the file Start Server.bat and change the path to Raven.Server.exe if you want

Finally I've hard coded the server uri in my code, you will need to change that too.