# Simple and Dirty API

Esta é uma API RESTful desenvolvida em C# (.NET) com um banco de dados SQLite, destinada a fornecer operações CRUD (Criar, Ler, Atualizar, Deletar) para um conjunto de recursos.

## Tecnologias Utilizadas

- **C#** - Linguagem de programação principal.
- **.NET** - Framework para desenvolvimento da API.
- **SQLite** - Banco de dados leve e embutido.
- **Entity Framework Core** - ORM para comunicação com o banco de dados SQLite.

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- `Controllers` - Contém os controladores da API.
- `Models` - Contém os modelos de dados.
- `Data` - Configurações do banco de dados e contexto.
- `Services` - Lógica de negócios e manipulação de dados.
  
## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão compatível com o projeto)
- Visual Studio ou Visual Studio Code (opcional, mas recomendado)
- SQLite (instalado ou embutido no projeto)

## Configuração do Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/sua-api-csharp-sqlite.git

2. Navegue até o diretório do projeto:
   ```bash
   cd sua-api-csharp-sqlite
3. Restaure as dependências do projeto:
   ```bash
   dotnet restore

4. Execute as migrações do banco de dados para criar o arquivo SQLite:
   ```bash
   dotnet ef database update

## Estrutura de Banco de Dados
A tabela Entidades no SQLite contém as seguintes colunas:

Id: Identificador único (chave primária)
Name: Nome
Phone: Telefone
Adress: Endereço

## Contribuição
Para contribuir com o projeto:

1. Faça um fork do repositório.
2. Crie uma branch para sua feature (git checkout -b feature/nova-feature).
3. Commit suas mudanças (git commit -m 'Adiciona nova feature').
4. Envie para o repositório remoto (git push origin feature/nova-feature).
5. Abra um Pull Request.

## Licença
Este projeto é licenciado sob a MIT License.

## Contato
