FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.sln ./
COPY *.config ./
COPY Lets.Importation.Api/Lets.Importation.Api.csproj/ Lets.Importation.Api/
COPY Lets.Importation.Domain/Lets.Importation.Domain.csproj/ Lets.Importation.Domain/
COPY Lets.Importation.Domain.Command/Lets.Importation.Domain.Command.csproj/ Lets.Importation.Domain.Command/
COPY Lets.Importation.Domain.Query/Lets.Importation.Domain.Query.csproj/ Lets.Importation.Domain.Query/
COPY Lets.Importation.Infrastructure.Database/Lets.Importation.Infrastructure.Database.csproj/ Lets.Importation.Infrastructure.Database/
RUN dotnet restore
COPY . .

WORKDIR /src/Lets.Importation.Api
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Lets.Importation.Api.dll"]