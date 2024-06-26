FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 7000

ENV ASPNETCORE_URLS=http://+:7000

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["CommunicationAPIGateWay/CommunicationAPIGateWay.csproj", "CommunicationAPIGateWay/"]
RUN dotnet restore "CommunicationAPIGateWay/CommunicationAPIGateWay.csproj"
COPY . .
WORKDIR "/src/CommunicationAPIGateWay"
RUN dotnet build "CommunicationAPIGateWay.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "CommunicationAPIGateWay.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CommunicationAPIGateWay.dll"]
