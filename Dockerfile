FROM microsoft/dotnet:runtime
WORKDIR /app

COPY ./bin/Release/netcoreapp2.1/linux-x64/publish ./
ENTRYPOINT ["./colortest"]
