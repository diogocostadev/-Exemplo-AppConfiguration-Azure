### README.md


# Exemplos de Recursos Azure com C#

Este repositório contém exemplos de como utilizar diferentes recursos do Azure com C#, utilizando .NET 8 e top-level statements. O foco principal é demonstrar como integrar e gerenciar configurações usando o Azure App Configuration.

## Sumário

- [Pré-requisitos](#pré-requisitos)
- [Configuração do Projeto](#configuração-do-projeto)
- [Configuração do Azure App Configuration](#configuração-do-azure-app-configuration)
- [Contribuições](#contribuições)
- [Licença](#licença)

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes pré-requisitos instalados:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Rider IDE](https://www.jetbrains.com/rider/) ou [VS Code]()
- Conta no [Azure](https://azure.microsoft.com/)

## Configuração do Projeto

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. **Instale os pacotes NuGet necessários:**

   ```bash
   dotnet add package Microsoft.Extensions.Configuration.AzureAppConfiguration
   dotnet add package Microsoft.Azure.AppConfiguration.AspNetCore
   ```

## Configuração do Azure App Configuration

1. **Criar um Recurso de App Configuration:**

   - Acesse o portal Azure.
   - Procure por "App Configuration" e clique em "Criar".
   - Preencha os detalhes necessários e clique em "Revisar e criar".

2. **Adicionar Chaves de Configuração:**

   - Acesse o recurso Azure App Configuration.
   - No painel esquerdo, clique em "Configuration Explorer".
   - Clique em "+ Create" para adicionar novas chaves. Exemplo:
     - Key: `empresa-projeto-chave`
     - Value: `***Valor***`
     - Label: `Development` | `Staging` | `Production` 

     - Key: `empresa:projeto:chave`
     - Value: `***Valor***`
     - Label: `Development` | `Staging` | `Production`



## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.


### LICENSE

```plaintext
MIT License

Copyright (c) 2024 [Seu Nome]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
