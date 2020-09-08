#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TiendaServicio.Api.Libro/TiendaServicio.Api.Libro.csproj", "TiendaServicio.Api.Libro/"]
RUN dotnet restore "TiendaServicio.Api.Libro/TiendaServicio.Api.Libro.csproj"
COPY . .
WORKDIR "/src/TiendaServicio.Api.Libro"
RUN dotnet build "TiendaServicio.Api.Libro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TiendaServicio.Api.Libro.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TiendaServicio.Api.Libro.dll"]