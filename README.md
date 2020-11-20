# Run
1. Download .NET 5.
2. `cd src\ServiceSystemMockServer`
3. `dotnet run`

Then `POST` to either `/orders` or `/stockreservations`; content `application/json` in both directions.

Runs on both Windows and Linux and defaults to port 5000 (HTTP) and 5001 (HTTPS).

Relevant routes in `src\ServiceSystemMockServer\Controllers`.