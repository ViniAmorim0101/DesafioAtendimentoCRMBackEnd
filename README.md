# Desafio Atendimento CRM

Desafio Atndimento CRM



Desafio Atendimento CRM



Este projeto foi desenvolvido como parte de um desafio técnico com foco em arquitetura limpa, boas práticas de desenvolvimento e organização de código. Trata-se de uma API para gerenciamento de atendimentos em um sistema de CRM, construída com .NET 8.



Tecnologias Utilizadas



\- \*\*.NET 8\*\*

\- \*\*Entity Framework Core\*\*

\- \*\*SQL Server\*\*

\- \*\*Arquitetura em camadas (Controller, Service, Repository, Model)\*\*

\- \*\*Migrações via EF Core\*\*

\- \*\*AppSettings para configuração de ambiente\*\*



Estrutura do Projeto



```

Desafio-Atendimento-CRM/

├── Controladores/

├── Dados/

├── Migrações/

├── Modelos/

├── Propriedades/

├── Repositório/

├── Serviço/

├── Program.cs

├── appsettings.json

└── Desafio-Atendimento-CRM.sln

```



Funcionalidades



\- Cadastro e gerenciamento de atendimentos

\- Integração com banco de dados via EF Core

\- Separação clara de responsabilidades entre camadas

\- Configuração de ambiente de desenvolvimento



Como Executar



1\. Clone o repositório:

&nbsp;  ```bash

&nbsp;  git clone https://github.com/ViniciusAmorimDev/Desafio-Atendimento-CRM.git

&nbsp;  ```

2\. Abra a solução no Visual Studio

3\. Configure a string de conexão no `appsettings.json`

4\. Execute as migrações:

&nbsp;  ```bash

&nbsp;  dotnet ef database update

&nbsp;  ```

5\. Inicie o projeto



Sobre o Autor



Desenvolvido por \[Vinicius Amorim](https://github.com/ViniciusAmorimDev), apaixonado por backend, arquitetura de software e desafios técnicos.

