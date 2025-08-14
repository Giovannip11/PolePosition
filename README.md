# PolePosition

Aplicação Blazor dedicada ao desempenho de pilotos, rankings e estatísticas de automobilismo, com filtros de categoria, pista, sexo e peso.

---

## Tecnologias Utilizadas

- **Blazor Server** (ASP.NET Core)  
- **C#**  
- **HTML / CSS**  
- **JSON** (para dados dos pilotos)  
- **Visual Studio 2022** ou **VS Code** (com .NET SDK instalado)  

---

## Pré-requisitos

Antes de rodar a aplicação, certifique-se de ter instalado:  

1. [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)  
2. Um editor de código (Visual Studio 2022, VS Code ou Rider)  
3. Navegador moderno (Chrome, Edge, Firefox)  

---

## Como rodar a aplicação localmente

1. **Clone o repositório** (ou baixe os arquivos):
git clone https://github.com/seu-usuario/poleposition.git

2. Acesse a pasta do projeto: cd poleposition
3. Rode a aplicação:dotnet run
# Estrutura do Projeto PolePosition

Este documento descreve a organização dos arquivos e pastas do projeto **PolePosition**, facilitando a compreensão de onde cada recurso está localizado.

---

## Estrutura de Pastas

- **Pages/**  
  Contém todas as páginas Blazor do projeto. Cada arquivo `.razor` representa uma página da aplicação.

- **Components/**  
  Componentes reutilizáveis que podem ser usados em várias páginas. Ex.: tabelas de ranking, filtros, gráficos.

- **wwwroot/**  
  Arquivos estáticos acessíveis pelo navegador:  
  - **css/**: estilos da aplicação  
  - **images/**: imagens, logos e ícones  
  - **js/**: scripts JavaScript, se necessário

- **Data/**  
  Armazena os dados em **JSON** ou outros formatos que a aplicação consome, como informações dos pilotos.

- **Program.cs**  
  Arquivo principal de configuração da aplicação Blazor Server. Configura serviços, rotas e dependências.

- **App.razor**  
  Componente raiz que define o roteamento da aplicação.

- **_Imports.razo_**
