var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Tripperist_ApiService>("apiservice");

builder.AddProject<Projects.Tripperist_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
