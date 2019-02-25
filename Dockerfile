FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY WebApp.csproj src/WebApp/
RUN dotnet restore src/WebApp/WebApp.csproj
WORKDIR /src/WebApp
COPY . .
RUN dotnet build WebApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WebApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApp.dll"]
