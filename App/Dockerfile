FROM microsoft/dotnet:2.1.400-sdk-alpine3.7  AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY /App.WebApi/*.csproj ./App.WebApi/
COPY /App.ServiceLibrary/*.csproj ./App.ServiceLibrary/
COPY /build/NuGet.Config ./

RUN dotnet restore --configfile NuGet.Config -nowarn:msb3202,nu1503

# Copy everything else and build
COPY . ./
RUN dotnet publish App.WebApi/*.csproj -c Release -o out

# Build runtime imagedock
FROM microsoft/dotnet:2.1.2-aspnetcore-runtime-alpine3.7
WORKDIR /app
COPY --from=build-env /app/src/App.WebApi/out .
ENV ASPNETCORE_ENVIRONMENT="Production"
ENTRYPOINT ["dotnet", "App.WebApi.dll"]
