
# Desafio Cast Group 🏆

-   Desenvolvimento de um projeto fazendo uso de uma API REST que fará o controle dos cursos de formação ministrados na empresa Cast Group.

## [](https://github.com/rick9141/challenger-cast-courses#para-rodar-esse-projeto-voc%C3%AA-vai-precisar-das-seguintes-ferramentas-exclamation)Pre requisitos para rodar o projeto  ❗

-   Visual Studio 2019, Visual Studio Code
-   .NET 5.0
-   SQL Server

## [](https://github.com/rick9141/challenger-cast-courses#tecnologias-implementadas-)Tecnologias Implementadas  ⚙

-   NET 5.0
-   Web API
-   Entity Framework Core 5.0.6

## [](https://github.com/rick9141/challenger-cast-courses#sobre-a-arquitetura-)Sobre a Arquitetura  📐

-   Utilização de conceitos básicos de introdução a metodologia de design de software DDD(Domain Driven Design)
-   Repository Pattern

## [](https://github.com/rick9141/challenger-cast-courses#configurando-o-projeto-)Configurando o projeto - Passo a passo 🔨

-   Clone o projeto através do comando "git clone https://github.com/rick9141/Challenge-Cast-Courses.git"
-   Configure a string de conexão com o banco de dados no arquivo ContextBase do projeto Infra/CastCourses.Infra.Data/Context
-   Abra o Console do Gerenciador de Pacotes (Ferramentas > Gerenciador de pacotes do NuGet > Console do Gerenciador de Pacotes)
-   Em projeto padrão defina o CastCourses.Infra.Data, ainda no console dê o seguinte comando: 
     Update-Database -Context ContextBase
-   Para abrir basta executar o projeto Application/Cast.Courses.Application e irá diretamente para a pagina do Swagger.


## [](https://github.com/rick9141/challenger-cast-courses#casos-de-uso-)Casos de uso ✒️

-   [GET] - getListCourses => Obtém uma lista de todos os cursos cadastrados até o momento.
-   [GET] - getCourseById => Procura um curso no banco de dados através do seu Id.
-   [POST] - newCourse => Cadastra um novo curso.
-   [PUT] - updateCourse => Atualiza/Altera informações de um determinado curso.
-   [DELETE] - removeCourse => Remove um curso.


## [](https://github.com/rick9141/challenger-cast-courses#tecnologias-implementadas-)Preview  🎥
