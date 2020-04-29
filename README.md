# sample-dotnet-api

Sample Dotnet API in Docker Environment

## Requirements

- [Docker](https://docs.docker.com/docker-for-windows/install/)
- [Dotnet Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio Community](https://visualstudio.microsoft.com/vs/)

## How to build

```
dotnet build
```

## How to unit test

```
dotnet test
```

## How to run API

run the following command and navigate to http://localhost:5000/WeatherForecast

```
dotnet run --project cicd-lab
```

## How to build image

```
docker build -t ${IMAGE_NAME} .
```
