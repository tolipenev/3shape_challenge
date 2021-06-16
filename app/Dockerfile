FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy and publish app and libraries
COPY . .
RUN dotnet build -c release -o /source/app

# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:5.0
ENV TOKEN=""
WORKDIR /app
COPY --from=build /source/app .
ENTRYPOINT dotnet 3shape_challenge.dll $TOKEN
