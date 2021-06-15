# 3shape Challenge

Application for calculating the remaining GitHub API points.

## Getting the source code

```bash
# Get the code
$ git clone https://github.com/tolipenev/3shape_challenge.git
$ cd 3shape_challenge
```

## Building the application

> Build using CMD

```bash
$ dotnet build
$ dotnet .\bin\Debug\net5.0\3shape_challenge.dll <TOKEN>
```

> Build using Docker

```bash
$ docker build .
```

## Running the application

> Using CMD

```bash
$ dotnet run -- <TOKEN>
```

> Using Docker

```bash
$ docker images # checking the IMAGE_ID
$ docker run -d -e TOKEN="" IMAGE_ID
```

## Debugging

If you would like to test the application, provide a token in the _launch.json_ in the _"args":_ field.
