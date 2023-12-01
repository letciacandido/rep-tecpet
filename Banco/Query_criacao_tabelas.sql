DELETE FROM tb_descricao_vendas;
DELETE FROM tb_vendas;
DELETE FROM tb_funcionarios;
DELETE FROM tb_estoque;


USE [tecpet]
GO

DROP TABLE tb_descricao_vendas;
DROP TABLE tb_vendas;
DROP TABLE tb_funcionarios;
DROP TABLE tb_estoque;

/****** Object:  Table [dbo].[tb_funcionarios]    Script Date: 15/11/2023 10:12:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_funcionarios](
  [ID] [int] IDENTITY(1,1) NOT NULL,
  [CPF] [char](14) NOT NULL,
  [nome] [varchar](70) NOT NULL,
  [email] [varchar](70) NOT NULL,
  [data_nasc] [date] NULL,
  [status] [char](7) NOT NULL,
  [foto] [varchar](255) NOT NULL,
  [senha] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
  [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tb_funcionarios]  WITH CHECK ADD CHECK  (([status]='INATIVO' OR [status]='ATIVO'))
GO

/****** Object:  Table [dbo].[tb_estoque]    Script Date: 15/11/2023 10:12:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_estoque](
  [SKU] [varchar](20) NOT NULL,
  [produto] [varchar](100) NULL,
  [valor_unitario] [decimal](10, 2) NULL,
  [qtd_estoque] [int] NULL,
  [img_produto] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
  [SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tb_vendas]    Script Date: 15/11/2023 14:44:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_vendas](
	[cod_venda] [int] IDENTITY(1,1) NOT NULL,
	[id_funcionario] [int] NULL,
	[data_venda] [datetime] NULL,
	[percentual_desconto] [int] NULL,
	[valor_total] [decimal](10, 2) NULL,
	[status] [char](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tb_vendas]  WITH CHECK ADD FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[tb_funcionarios] ([ID])
GO


/****** Object:  Table [dbo].[tb_descricao_vendas]    Script Date: 15/11/2023 10:14:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_descricao_vendas](
  [cod_venda] [int] NOT NULL,
  [SKU] [varchar](20) NULL,
  [valor_unitario] [decimal](10, 2) NULL,
  [quantidade] [int] NULL,
  [valor_total] [decimal](10, 2) NULL,
  [valor_pago]  [decimal] (10,2) NULL,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tb_descricao_vendas]  WITH CHECK ADD FOREIGN KEY([cod_venda])
REFERENCES [dbo].[tb_vendas] ([cod_venda])
GO

ALTER TABLE [dbo].[tb_descricao_vendas]  WITH CHECK ADD FOREIGN KEY([SKU])
REFERENCES [dbo].[tb_estoque] ([SKU])
GO


SELECT * FROM tb_estoque;
SELECT * FROM tb_descricao_vendas;
SELECT * FROM tb_funcionarios;
SELECT * FROM tb_vendas;
