create database DEV211601
go
USE DEV211601
go
CREATE TABLE tabUsuario(
id int identity(1,1) primary key,
nome varchar(200) not null,
email varchar(200) not null,
senha varchar(200) not null,
dataUltimoAcesso datetime null,
dataCadastro datetime not null,
dataNascimento datetime not null
)
go
select * from tabUsuario