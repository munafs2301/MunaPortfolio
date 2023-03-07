FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build /app/out/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf