# Market
Rest API
SuperMarket


O software em questão foi construído através de um projeto dotnet no visual studio.

Arquitetura: Optou-se pela utilização da arquitetura MVC (model-view-controller) para a construção do projeto em questão devido a suas características e facilidades de uso.

Banco de dados: Para o armazenamento dos dados optou-se pela utilização do banco de dados SQLite, uma vez que o mesmo é recomendado para aplicações simples, onde as funcionalidades e incontáveis recursos de um SGBD são dispensáveis, como é o caso da aplicação em questão. A escolha do SQLite também foi impulsionada devido à simplicidade de manipulação do banco, uma vez que os dados ficam salvos em um único arquivo .db. O banco de dados foi gerado através do recurso “migrations” do entity framework, por linha de comando. No banco de dados foi criado apenas um tabela, para descrever o produto, onde o atributo “code” foi definido como chave primári.
 

Camada de persistência: Na camada de persitência optou-se por utitlizar o Entity Framework(EF)  que é ORMs (Object-Relational Mappers) , este permite realizar acesso a um banco de dados relacional e realizar as principais operações de manutenção CRUD

Backend: O back-end do projeto contém os arquivos principais descritos abaixo:
• Product.cs: onde está descrito o modelo de dado, para o produto.
Controller: 
SupermarketController.cs

Frontend: O frontend do projeto contém os arquivos principais descritos abaixo:
•	Index.html: tela de listagem dos produtos (tela inicial da aplicação), onde existe a opção de redirecionamento para a tela de edição do item selecionado e também a opção remoção de cada item através da chamada ao método DELETE do REST API criado no backend;

•	EditProduct.html: tela de edição de um produto, onde um produto existente pode ser alterado com a chamada de o método PUT do Rest API.

•	newProduct.html tela de criação de um novo produto, onde os dados são inseridos e uma request do tipo POST é realizada no REST API. 

•	mainStyle.css: arquivo de estilização utilizado na construção das páginas da aplicação.


Instruções para execução: Para execução do projeto, o mesmo deve ser startado no Visual Studio, ou deployado no IIS.



