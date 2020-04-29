DOCKER_REGISTRY_HOST ?= 
IMAGE_NAME ?= sampleapi
VERSION ?= 0.0.0

test:
	dotnet test --logger trx --results-directory TestResults

build:
	dotnet build

image:
	docker build -t ${IMAGE_NAME} .