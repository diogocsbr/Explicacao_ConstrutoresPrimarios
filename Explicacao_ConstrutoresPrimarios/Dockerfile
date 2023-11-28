FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Explicacao_ConstrutoresPrimarios/Explicacao_ConstrutoresPrimarios.csproj", "Explicacao_ConstrutoresPrimarios/"]
RUN dotnet restore "Explicacao_ConstrutoresPrimarios/Explicacao_ConstrutoresPrimarios.csproj"
COPY . .
WORKDIR "/src/Explicacao_ConstrutoresPrimarios"
RUN dotnet build "Explicacao_ConstrutoresPrimarios.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Explicacao_ConstrutoresPrimarios.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Explicacao_ConstrutoresPrimarios.dll"]
