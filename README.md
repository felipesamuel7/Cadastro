# Cadastro
Estrutura de Solução em camadas.

Script de criação da tabela usada na Solução.

CREATE DATABASE Estudos;

USE Estudos;

CREATE TABLE Pessoa
( id_pessoa int NOT NULL IDENTITY (1,1),
  nome varchar(100) NOT NULL,
  idade int NOT NULL,
  data_nascimento datetime NOT NULL,
  CONSTRAINT departments_pk PRIMARY KEY (id_pessoa)
);
