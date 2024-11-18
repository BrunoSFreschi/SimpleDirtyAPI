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
