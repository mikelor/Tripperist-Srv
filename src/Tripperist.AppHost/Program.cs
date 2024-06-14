var builder = DistributedApplication.CreateBuilder(args);

// Add Places Database 
var dbServer = builder.AddPostgres("dbServer");
var placesDb = dbServer.AddDatabase("PlacesDb");

var apiService = builder.AddProject<Projects.Tripperist_ApiService>("apiservice")
    .WithReference(placesDb);

builder.AddProject<Projects.Tripperist_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);
    

builder.Build().Run();
