# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["FsMongoExample.fsproj", "./"]
RUN dotnet restore "FsMongoExample.fsproj"
COPY . .
RUN dotnet publish "FsMongoExample.fsproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "FsMongoExample.dll"]
