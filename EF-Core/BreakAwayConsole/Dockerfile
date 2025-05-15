FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["BreakAwayConsole/BreakAwayConsole.csproj", "BreakAwayConsole/"]
RUN dotnet restore "BreakAwayConsole/BreakAwayConsole.csproj"
COPY . .
WORKDIR "/src/BreakAwayConsole"
RUN dotnet build "BreakAwayConsole.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BreakAwayConsole.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BreakAwayConsole.dll"]
