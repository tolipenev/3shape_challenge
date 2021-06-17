FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy and publish app and libraries
COPY /app ./app
RUN cd app && dotnet build -o dist

# copy and test app
COPY /tests ./tests
RUN cd tests && dotnet test

# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:5.0
ENV TOKEN=""
WORKDIR /app
COPY --from=build /source/app/dist .
ENTRYPOINT dotnet 3shape_challenge.dll $TOKEN
