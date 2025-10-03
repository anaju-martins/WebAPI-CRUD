# Web API .NET 8: CRUD com Repository Pattern

## 📖 Sobre o Projeto

Este projeto é uma Web API desenvolvida em .NET 8 que implementa um CRUD para gerenciar Autores e Livros. O principal objetivo foi reforçar meus conhecimentos em Entity Framework Core e na aplicação Repository Pattern.



## ✨ Funcionalidades

A API fornece endpoints para realizar as quatro operações básicas (CRUD) para as entidades Autor e Livro, que possuem um relacionamento de um-para-muitos (um autor pode ter vários livros).

- Endpoints de Autor: Permitem criar, listar, buscar por ID, editar e excluir autores.

- Endpoints de Livro: Permitem criar, listar, buscar por ID, editar e excluir livros, sempre os associando a um autor.

---

## 🛠️ Tecnologias e Conceitos Aplicados

Durante o desenvolvimento, pude praticar e consolidar os seguintes conceitos:

**Repository Pattern:** Abstração da camada de acesso a dados com o uso de interfaces e serviços, desacoplando a lógica de negócio e facilitando a manutenção.

**Entity Framework Core:**

- Uso da abordagem Code-First para criar o banco de dados e suas tabelas a partir dos modelos C#.

- Configuração de relacionamentos entre entidades.

- Injeção de dependência do DbContext.

- Realização de consultas assíncronas para otimizar a performance.
