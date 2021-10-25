--- Criando banco de dados db_livraria ----

create database db_livraria

--- Informando banco de dados q desejo trabalhar ---

use db_livraria

create table tbl_atendente
(
	cd_Atendente int primary key identity,
	ds_Login varchar(20) not null,
	ds_Senha char(8) not null,
	nm_Atendente varchar(60) not null
)

--- Inserindo dados na tabela atendente nos campos ---

insert into tbl_atendente
(ds_Login,ds_Senha,nm_Atendente)
values('tiagomoraes','admin01','Jonatan')

--- Verificar a tabela ---

select * from tbl_atendente
where ds_login = 'tiagomoraes' and ds_Senha = 'admin01'


--- Selecione todos os campos da tabela atendente ---
select * from tbl_atendente

--- Criando a tabela Cliente ---

create table tbl_Cliente
(
	cd_CLiente int primary key identity,
	nm_Cliente varchar(60) not null,
	ds_Email varchar(60) not null,
	num_CPF char(11) null,
	num_CNPJ char(14) null,
	nm_Logradouro varchar(60) not null,
	num_Logradouro varchar(5) not null,
	ds_Complemento varchar(20) null,
	nm_Bairro varchar(20) not null,
	nm_Cidade varchar(20) not null,
	sg_UF char(2) not null,
	num_CEP char(8) not null
)

alter table tbl_Cliente
add ds_status bit not null

--- Criando a tabela Telefone ---

create table tbl_Telefone
(
	cd_Cliente int,
	num_Telefone char(11)
	primary key(cd_Cliente, num_Telefone)
	foreign key(cd_Cliente) references tbl_Cliente(cd_Cliente)
)

select * from tbl_Cliente
select * from tbl_Telefone

select * from tbl_atendente
 
 --- Remova da tabela atendente ---
 delete from tbl_atendente
 where cd_Atendente = 7 

 --- criando colunas ---
 alter table tbl_atendente
 add ds_status bit not null default(1)

  --- Excluindo funcionarios ---
 update tbl_atendente
 set ds_status = 0
 where cd_Atendente = 8 
 

 --- Exeibindo Funcionarios ativos ---
 select * from tbl_atendente
 where ds_status = 1

  --- Exeibindo Funcionarios inativos ---
 select * from tbl_atendente
 where ds_Login = '' and ds_Senha = ''


select * from tbl_Cliente




