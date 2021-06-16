FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy and publish app and libraries
COPY . .
RUN dotnet build -c release -o /3shape_challenge

# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:5.0
ENV TOKEN=""
WORKDIR /3shape_challenge
COPY --from=build /3shape_challenge .
ENTRYPOINT dotnet 3shape_challenge.dll $TOKEN
