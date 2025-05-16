var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.Blockchain_Based_Voting_System_ApiService>("apiservice");

builder.AddProject<Projects.Blockchain_Based_Voting_System_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WithReference(apiService);

builder.Build().Run();
