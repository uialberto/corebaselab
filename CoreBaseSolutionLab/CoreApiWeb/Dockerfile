#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CoreApiWeb/CoreApiWeb.csproj", "CoreApiWeb/"]
RUN dotnet restore "CoreApiWeb/CoreApiWeb.csproj"
COPY . .
WORKDIR "/src/CoreApiWeb"
RUN dotnet build "CoreApiWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoreApiWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoreApiWeb.dll"]