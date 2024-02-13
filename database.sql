CREATE DATABASE BIBLIO_API;
USE BIBLIO_API;

CREATE TABLE Livro (
id int not null primary key identity(1,1),
titulo varchar(100) not null,
autor varchar(100) not null,
genero varchar(100) not null,
editora varchar(100) not null,
anoPublicacao int not null,
numeroPaginas int not null
);