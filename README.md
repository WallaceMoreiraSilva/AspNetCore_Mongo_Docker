# Tecnologia usada
AspNetCore + Mongo + Docker

-- Instalar o Docket Desktop => https://www.docker.com/products/docker-desktop

# Conceitos fundamentais de docker

--Imagens => Base para criação de containers, são geradas a partir do arquivo dockerfile. Contém todos os
arquivos e dependencias de uma aplicação, incluindo sistema operacional

--Containers => instância de uma aplicação (serviço, site, API) criada a partir de uma imagem

#Explicação para entendimento do docker

Se clicar no Projeto com o botão direito e apertar add. Você verá as duas opções abaixo:

	Container Orchestrator Suport...  => se eu quiser criar o docker compose
 
	Docker Support...  => se eu quiser trabalhar com docker file

--O DockerFile é um arquivo de texto que contem todos os comandos, em ordem, necessarios para construir uma 
determinada imagem.

-- A API será executada dentro do conteiner

obs: catalog-mongo é a imagem
obs: CatalogoAPI é o conteiner

--Vamos executar a API em um conteiner e a API vai acessar o mongoDB em outro conteiner. Portanto, vamos usar 
a orquestracao dos conteiners usando docker compose.
 
Obs: docker-compose => É uma ferramenta usada para descrever aplicações complexas e gerenciar conteineres, redes e 
volumes que essas aplicacoes exigem para funcionar. Usa um arquivo no formato YAML(extensao .yml) para configurar 
os serviços das aplicações

obs: O docker-compose simplifica o processo de configuração e execucao de aplicativos para que nao tenhamos que 
digitar comandos complexos, o que pode levar a erros de configuração.


#Explicando o arquivo dockerfile

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base    => Cria uma camada a partir da imagem asp .net 5.0
WORKDIR /app     => Define o diretorio de trabalho de um conteiner do Docker
EXPOSE 80        => Expoe a porta na qual o conteiner esta escutando

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Catalog.API/Catalog.API.csproj", "Catalog.API/"]  
RUN dotnet restore "Catalog.API/Catalog.API.csproj"
COPY . .  => Copia arquivos entreo cliente(local) e o conteiner
WORKDIR "/src/Catalog.API"
RUN dotnet build "Catalog.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.API.dll"]    => Executa um comando quando o Conteiner for inciado


#Explicando o arquivo docker-compose

services => indica os servicos que serão criados. Aqui definimos os conteineres usados e suas configurações

volumes => Define os recursos usados pelos serviços, eu acho que é onde vai ser criado um backup tb

networks => Define os recursos usados pelos serviços


