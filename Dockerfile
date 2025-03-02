# Use official .NET 8 SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy and restore dependencies
COPY . .
RUN dotnet restore

# Build the application
RUN dotnet publish -c Release -o /out

# Use runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy built application
COPY --from=build /out .

ENV PORT=5041
EXPOSE 5041


# Run the application on port 5000
CMD ["dotnet", "ArgoCdApi.dll"]
