FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /3shape_challenge/app

# copy and publish app and libraries
COPY . .
RUN dotnet build -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:5.0
ENV TOKEN=""
WORKDIR /3shape_challenge/app
COPY --from=build /app .
ENTRYPOINT dotnet 3shape_challenge.dll $TOKEN
