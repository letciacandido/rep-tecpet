--SCRIPT PARA PC LETICIA
USE tecpet;

INSERT INTO tb_estoque (SKU, produto, valor_unitario, qtd_estoque, img_produto)
VALUES 
('AB123C4', 'RA��O PARA C�ES', 31.46, 200, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\AB123C4-RACAO-CAES.JPG'),
('CD234E5', 'BRINQUEDO PARA GATOS', 15.99, 200, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\BRINQUEDO-GATO.PNG'),
('EF345G6', 'COLEIRA', 10.00, 100, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\COLEIRA.JPG'),
('GH456I7', 'CAMA PARA C�ES', 50.00, 50, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\CAMA-CACHORRO.PNG'),
('IJ567K8', 'SHAMPOO PARA C�ES', 20.00, 100, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\SHAMPOO-CACHORRO.JPEG'),
('KL678L9', 'RA��O PARA GATOS', 25.00, 150, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\RACAO-GATO.JPG'),
('MN789M1', 'CASINHA PARA C�ES', 100.00, 20, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\CASA-CACHORRO.JPG'),
('OP890N2', 'ARRANHADOR PARA GATOS', 35.00, 50, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\ARRANHADOR-GATO.JPG'),
('QR901O3', 'OSSO PARA C�ES', 5.00, 300, 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\RECURSOS\IMG-PRODUTOS\OSSO-CACHORRO.JPG');

INSERT INTO tb_funcionarios (CPF, nome, email, data_nasc, status, foto, senha)
VALUES ('11111111111', 'MOQUIDESIA DA SILVA', 'MOQUI@GMAIL.COM', '2023-10-30', 'ATIVO', 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\BIN\DEBUG\FOTOS\MOQUIDESIA.JPG', 123),
('22222222222', 'BRAD PITT BEZERRILA', 'BRAD@HOTMAIL.COM', '1997-10-31', 'ATIVO', 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\BIN\DEBUG\FOTOS\BRAD.JPG', 123),
('33333333333', 'JOSE BEZERRA', 'JOSE@GMAIL.COM', '2000-11-07', 'ATIVO', 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\BIN\DEBUG\FOTOS\JOSE.JPG', 123),
('55555555555', 'ANGELINA JOLIE', 'ANGEL@GMAIL.COM', '1980-11-07', 'ATIVO', 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\BIN\DEBUG\FOTOS\JUREMA.JPG', 123),
('66666666666', 'JUREMA DOS SANTOS', 'JU@HOTMAIL.COM', '1960-07-08', 'ATIVO', 'C:\USERS\LETICIACANDIDO\ONEDRIVE\6.STUDY\03.FACULDADE\FATEC\02. 2O SEMESTRE\ISI002 SISTEMAS DE INFORMACAO\03.PROJETO_INTERDISCIPLINAR\PRJ_TECPET\BIN\DEBUG\FOTOS\JUREMA.JPG', 123);