FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["RabbitMq.Banking.Api/RabbitMq.Banking.Api.csproj", "RabbitMq.Banking.Api/"]
RUN dotnet restore "RabbitMq.Banking.Api/RabbitMq.Banking.Api.csproj"
COPY . .
WORKDIR "/src/RabbitMq.Banking.Api"
RUN dotnet build "RabbitMq.Banking.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RabbitMq.Banking.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RabbitMq.Banking.Api.dll"]