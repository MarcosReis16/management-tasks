FROM mcr.microsoft.com/dotnet/runtime:6.0-alpine3.15 AS base
WORKDIR /out

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY src/management-tasks-api/ ./management-tasks-api/
COPY src/management-tasks-application/ ./management-tasks-application/
COPY src/management-tasks-domain/ ./management-tasks-domain/
COPY src/management-tasks-infra-persistence/ ./management-tasks-infra-persistence/

RUN dotnet publish ./management-tasks-api/Management.Tasks.API.csproj -c release -o /out -r alpine.3.15 -f net6.0 --self-contained

FROM base AS runtime
WORKDIR /out

COPY --from=build /out .
ENV ASPNETCORE_URL http://*80
EXPOSE 80
ENTRYPOINT ["./Management.Tasks.Api"]
