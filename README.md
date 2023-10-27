# Movie CRUD API (ASP.NET Core)

Este é um projeto ASP.NET Core que fornece uma API para criar, ler, atualizar e excluir filmes em uma lista de filmes.

## Requisitos

Certifique-se de ter o SDK do .NET Core instalado em sua máquina. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet).

## Instalação e Execução

1. Clone este repositório em sua máquina local:

   ```bash
   git clone https://github.com/armandogomes92/ListarFilmes.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd ListarFilmes
   ```

3. Para iniciar o aplicativo, execute o seguinte comando:

   ```bash
   dotnet run
   ```

Isso iniciará a API em [https://localhost:5001](http://localhost:5000).

## Rotas da API

A API oferece as seguintes rotas para realizar operações CRUD em filmes:

- **GET /api/filmes:** Obtém a lista de todos os filmes.
- **POST /api/filmes:** Adiciona um novo filme.
- **PUT /api/filmes/{id}:** Atualiza as informações de um filme existente.
- **DELETE /api/filmes/{id}:** Remove um filme da lista.

 e rotas para realizar operações GET em Genero:

- **GET /api/genero:** Obtém a lista de todos os generos.

Certifique-se de usar uma ferramenta de API como o [Postman](https://www.postman.com/) para testar as rotas da API.

## Estrutura do Projeto

A estrutura do projeto é organizada da seguinte forma:

- `Controllers/` - Contém os controladores da API.
- `Models/` - Define os modelos de dados para filmes.
- `Data/` - Acesso ao contexto
- `Startup.cs` - Configuração da aplicação.
- `appsettings.json` - Configurações de aplicativo, como a conexão com o banco de dados.

## Banco de Dados

Este projeto usa um banco de dados SQL Server para armazenar os filmes. Certifique-se de configurar a conexão com o banco de dados no arquivo `appsettings.json`.
Basta criar uma instacia local chamada de FilmeDB, configurar o arquivo `appsettings.json` e abrir o console do gerenciador de pacotes para executar o comando:
```bash
Update-Database
```
upa

Após a conclusão do passo anterior, deve se executar o seguinte comando sql sendo este suficiente para iniciar a aplicação podendo cadastrar os filmes de sua preferencia
```bash
INSERT INTO generoDeFilmes (Nome, DataCriacao, Ativo)
VALUES
    ('Ação', '2023-10-27 10:30:00', 1),
    ('Comédia', '2023-10-26 15:45:00', 1),
    ('Drama', '2023-10-25 20:15:00', 1),
    ('Ficção Científica', '2023-10-24 14:20:00', 1),
    ('Aventura', '2023-10-23 09:00:00', 1),
    ('Terror', '2023-10-22 18:10:00', 1),
    ('Romance', '2023-10-21 12:30:00', 1),
    ('Fantasia', '2023-10-20 08:45:00', 1),
    ('Suspense', '2023-10-19 11:55:00', 1),
    ('Animação', '2023-10-18 16:25:00', 1);
```
e também
```bash
INSERT INTO NomeDaSuaTabelaDeFilmes (Nome, DataCriacao, Ativo, GeneroId)
VALUES
    ('O Poderoso Chefão', '2023-10-27 14:00:00', 1, 1),
    ('Forrest Gump', '2023-10-26 16:30:00', 1, 3),
    ('Titanic', '2023-10-25 12:45:00', 1, 2),
    ('Interestelar', '2023-10-24 09:15:00', 1, 5),
    ('Star Wars: Episódio IV', '2023-10-23 20:00:00', 1, 4);
```
Divirta-se
