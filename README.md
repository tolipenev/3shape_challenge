# 3shape Challenge

Application for calculating the remaining GitHub API points.

<br />

## Building the application

> Build using CMD

```bash
# Get the code
$ git clone https://github.com/tolipenev/3shape_challenge.git
$ cd 3shape_challenge

# Add required package
$ dotnet add package Newtonsoft.Json #required for Deserialization of Json

# Restore the application
$ dotnet restore
```

> Build using Docker

```bash
# Get the code
$ git clone https://github.com/tolipenev/3shape_challenge.git
$ cd 3shape_challenge

# Build the docker image
$ docker build .
```

## Running the application

> Using CMD

```bash
$ dotnet run
```

> Using Docker

```bash
$ docker images # checking the IMAGE_ID
$ docker run -d -e TOKEN="" IMAGE_ID
```

## Debugging
