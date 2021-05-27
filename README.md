# AspNetCore_Mongo_Docker
AspNetCore + Mongo + Docker

-- Instalar o Docket Desktop => https://www.docker.com/products/docker-desktop

#Explicação 

Clique no Projeto com o Botao direito e aperte Add:

	Container Orchestrator Suport...  => se eu quiser criar o docker compose
 
	Docker Support...  => se eu quiser trabalhar com docker file

--O DockerFile é um arquivo de texto que contem todos os comandos, em ordem, necessarios para construir uma 
determinada imagem.

-- A API será executada dentro do conteiner

obs: CatalogoAPI é o conteiner
obs: catalog-mongo é a imagem

--Vamos executar a API em um conteiner e a API vai acessar o mongoDB em outro conteiner. Portanto, vamos usar 
a orquestracao dos conteiners usando docker compose.
 
Obs: docker-compose => É uma ferramenta usada para descrever aplicações complexas e gerenciar conteineres, redes e 
volumes que essas aplicacoes exigem para funcionar. Usa um arquivo no formato YAML(extensao .yml) para configurar 
os serviços das aplicações

obs: O docker-compose simplifica o processo de configuração e execucao de aplicativos para que nao tenhamos que 
digitar comandos complexos, o que pode levar a erros de configuração.





