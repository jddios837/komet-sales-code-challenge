FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Sales.ManagementSystem.API/Sales.ManagementSystem.API.csproj", "Sales.ManagementSystem.API/"]
RUN dotnet restore "Sales.ManagementSystem.API/Sales.ManagementSystem.API.csproj"
COPY . .
WORKDIR "/src/Sales.ManagementSystem.API"
RUN dotnet build "Sales.ManagementSystem.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sales.ManagementSystem.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sales.ManagementSystem.API.dll"]
