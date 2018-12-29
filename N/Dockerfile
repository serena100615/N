FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["N/N.csproj", "N/"]
RUN dotnet restore "N/N.csproj"
COPY . .
WORKDIR "/src/N"
RUN dotnet build "N.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "N.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "N.dll"]