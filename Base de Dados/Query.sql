Use WebChef;

Insert into Acao (nome, descricao)
	VALUES
		('Cortar aos cubos', 'Cortar em cubos pequenos um alimento'), -- 1
		('Espremer', ' Extrair, por compress�o, o suco ou o l�quido de um fruto ou de qualquer outro alimento'),
		('Marinar', 'Colocar um alimento, numa mistura de um l�quido e temperos, durante um intervalo de tempo variado'),
		('Cortar', 'Cortar um alimento'),
		('Descascar', 'Tirar a casca de um alimento'), -- 5
		('Ferver �gua', 'Colocar uma panela com �gua ao lume e esperar que esta ferva'),
		('Adicionar � �gua ao lume', 'Adicionar algum alimento � �gua que est� a ferver'),
		('Picar', 'Cortar em peda�os muito pequeninos qualquer tipo de alimento'),
		('Partir os ovos', 'Partir a casca do ovo de modo a aproveitar o conte�do'),
		('Escalfar', 'Deixar estar durante algum tempo em �gua muito quente (a ferver)'), -- 10
		('Ralar', 'Raspar com o ralador'),
		('Polvilhar', 'Cobrir ou salpicar com uma especiaria ou alimento'),
		('Servir', 'P�r na mesa num recipiente apropriado'),
		('Retirar concha e adicionar a uma tijela', 'Retirar com uma concha(colher grande e funda usada para retirar l�quidos de um recepiente) conte�do do caldo e colocar num recipiente � parte'),
		('Misturar', 'Juntar os v�rios ingredientes'), -- 15
		('Cortar �s rodelas', 'Cortar o alimento em forma de rodelas'),
		('Cortar em tiras', 'Cortar o alimento em tiras'),
		('Deixar cozinhar', 'Deixar a panela ao lume durante um certo intervalo de tempo');-- 18
-- SELECT * FROM Acao;
-- Delete from Acao;


Insert into Ingrediente (designacao, imagem)
	VALUES
		('�gua', '~/Images/agua.jpg'),
		('Cebola', '~/Images/cebola.jpg'),
		('Tofu', '~/Images/tofu.jpg'),
		('Agri�o', '~/Images/agriao.jpg'),
		('Ovo', '~/Images/ovo.jpg'),
		('Semente de s�samo', '~/Images/sementeSesamo.jpg'),
		('Alho', '~/Images/alho.jpg'),
		('Molho de soja', '~/Images/molhoSoja.jpg'),
		('Folha de louro', '~/Images/folhaLouro.jpg'),
		('Pimenta', '~/Images/pimenta.jpg'),
		('Lima', '~/Images/lima.jpg'),
		('Coentros', '~/Images/coentros.jpg'),
		('Alho-franc�s', '~/Images/alhoFrances.jpg'),
		('Gengibre', '~/Images/gengibre.jpg'),
		('Alho-Franc�s em tiras', '~/Images/alhoFrancesTiras.jpg'),
		('Casca de lima', '~/Images/cascaLima.jpg'),
		('Cebola cortada', '~/Images/cebolaCortada.jpg'),
		('Cebola descascada', '~/Images/cebolaDescascada.jpg'),
		('Coentros picados', '~/Images/coentrosPicada.jpg'),
		('Dentes de alho', '~/Images/dentesAlho.jpg'),
		('Gengibre ralado', '~/Images/gengibreRalado.jpg'),
		('Ovo escalfado', '~/Images/ovoEscalfado.jpg'),
		('Sumo de lima', '~/Images/sumoLima.jpg'),
		('Ovo sem casca', '~/Images/ovoAberto.jpg'),
		('Marinada', '~/Images/marinada.jpg'),
		

		('Cenoura', '~/Images/cenoura.jpg'),
		('Curgete', '~/Images/curgete.jpg'),
		('Cebolinho', '~/Images/cebolinho.jpg'),
		('Miso', '~/Images/miso.jpg'),
		('Cogumelos', '~/Images/cogumelos.jpg'),
		('Noodles de arroz', '~/Images/noodlesArroz.jpg'),
		('�leo de coco', '~/Images/oleoCoco.jpg'),
		('Flocos de malagueta', '~/Images/flocosMalagueta.jpg'),
		('Caldo para o miso','~/Images/sopaSemMiso.jpg'),
		('Cenoura em fatias', '~/Images/cenouraFatiada.jpg'),
		('Rodelas de curgete', '~/Images/curgeteRodelas.jpg'),
		('Cebolinho picado', '~/Images/cebolinhoPicado.jpg'),
		('Rodelas de cogumelos', '~/Images/cogumelosFatiados.jpg'),

		('Sopa de agri�o com ovos', '~/Images/sopaAgriao.jpg'),
		('Sopa de miso', '~/Images/sopaMiso.jpg'),
		('Caldo com o miso', '~/Images/caldoMiso.jpg');
-- SELECT * FROM Ingrediente;
-- Delete from Ingrediente;


Insert into Passo (descricao, timestamp, id_acao, duracao)
	VALUES
		('Cortar o tofu em cubos pequenos', '0073', 1, null),
		('Espremer a lima para um recipiente', '0010', 2, null),
		('Colocar o tofu cortado aos cubos a marinar juntamente com o sumo de lima, molho de soja e pimenta durante 2 horas', '0010', 3, 7200),
		('Cortar casca da lima', '0010', 4, null),
		('Descascar o alho', '0010', 5, null),
		('Descascar a cebola', '0010', 5, null),
		('Cortar a cebola', '0010', 17, null),
		('Ferver �gua ao lume', '0010', 6, null),
		('Adicionar cebola cortada, folha de louro, os dentes de alho e a casca de lima � �gua', '0010', 7, null),
		('Cortar o alho-franc�s em tiras', '0010', 17, null),
		('Picar os coentros', '0010', 8, null),
		('Adicionar o alfo-franc�s cortado em tiras, os coentros picados, agri�o, tofu e respetiva marinada � �gua', '0010', 7, null),
		('Partir os ovos', '0010', 9, null),
		('Escalfar os ovos junto da sopa que est� ao lume durante 3 minutos', '0010', 10, 180),
		('Servir a sopa num recipiente apropriado', '0010', 13, null), --15
		('Ralar o gengibre', '0010', 11, null),
		('Polvilhar a sopa com o gengibre ralado', '0010', 12, null),
		('Polvilhar a sopa com sementes de s�samo', '0017', 12, null), -- 18
		


		('Ferver �gua ao lume', null, 6, null), --19
		('Cortar os cogumelos e a curgete em rodelas', null, 16, null),
		('Cortar a cenoura �s fatias', null, 17, null),
		('Picar o cebolinho', null, 8, null),
		('Adicionar as rodelas de curgete, as rodelas de cogumelos, as tiras de cenoura e o cebolinho picado � �gua', null, 7, null),
		('Deixar cozinhar durante 10 minutos', null, 18, 600),
		('Retirar uma concha do caldo e colocar numa tigela', null, 14, null),
		('Misturar o miso com o caldo na tigela', null, 15, null),
		('Adicionar o caldo de volta', null, 7, null),
		('Cortar o tofu em cubos pequenos', null, 1, null),
		('Adicionar o tofu em cubos, o molho de soja, os noodles de arroz e o �leo de coco � �gua', null, 7, null),
		('Deixar cozinhar durante 5 minutos', null, 18, 300),
		('Servir a sopa num recipiente apropriado', null, 13, null),
		('Picar o cebolinho', null, 8, null),
		('Polvilhar a sopa com o cebolinho picado e os flocos de malagueta', null, 12, null);
-- SELECT * FROM Passo;
-- Delete from Passo;


INSERT INTO Receita (nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		('Sopa de Agri�o', 'Torne o seu dia mais saud�vel e saboroso com esta receita que junta ingredientes vegetarianos com o melhor da cozinha portuguesa.', '50|15|2|13|23|4|2|3|', 1800, 'https://www.youtube.com/embed/gS2WtZHvvWk?start=', '~/Images/sopaAgriao.jpg', 4, 'M�dio', 'Sopas'),
		('Sopa de Miso', 'Inspire-se nos sabores japoneses e aprecie esta sopa de miso. Um alimento fermentado e com v�rios benef�cios nutricionais, nomeadamente na flora intestinal.', '149|5|1|16|4|3|9|1,16|', 3600, null, '~/Images/sopaMiso.jpg', 4, 'F�cil', 'Sopas');
-- SELECT * FROM Receita;
-- Delete from Receita;


INSERT INTO Utilizador(nome, email, password)
	VALUES
		('admin', 'admin@gmail.com', '21232f297a57a5a743894a0e4a801fc3');
-- SELECT * FROM Utilizador;
-- Delete from Utilizador;


Insert into IngredienteLocalizacao (id_localizacao, id_ingrediente)
	VALUES
		(1, 1),
		(2, 2),
		(2, 3);
-- SELECT * FROM IngredienteLocalizacao;
-- Delete from IngredienteLocalizacao;

Insert into PassoIngrediente (id_passo, id_ingrediente, quantidade)
	VALUES
		(1, 3, '200 g'),
		
		(2, 11, '1 unidade'),
		
		(3, 3, '200 g'),
		(3, 23, null),
		(3, 8, '1 colher de ch�'),
		(3, 10, '1 colher de caf�'),

		(4, 11, '1 unidade'),
		
		(5, 7, '1 unidade'),
		
		(6, 2, '125 g'),
		
		(7, 18, null),
		
		(8, 1, '800 ml'),

		(9, 17, null),
		(9, 9, '1 unidade'),
		(9, 20, '4 unidades'),
		(9, 16, null),

		(10, 13, '100 g'),

		(11, 12, '20 g'),

		(12, 15, null),
		(12, 4, '600 g'),
		(12, 3, '200 g'),
		(12, 25, null),
		(12, 19, null),

		(13, 5, '4 unidades'),

		(14, 24, '4 unidade'),

		(15, 39, null),

		(16, 14, '10 g'),

		(17, 21, null),

		(18, 6, null),
		
		
		
		(19, 1, '6 ch�venas'),

		(20, 30, '10 unidades'),
		(20, 27, '1 unidade'),

		(21, 26, '1 unidade'),

		(22, 28, '15 g'),

		(23, 38, null),
		(23, 37, null),
		(23, 36, null),
		(23, 35, null),

		(25, 34, null),

		(26, 34, null),
		(26, 29, '2 colheres de sopa'),

		(27, 41, null), -- juncao dos anteriores

		(28, 3, '200 g'),

		(29, 3, null),
		(29, 32, '1 colher de caf�'),
		(29, 8, '1 colher de ch�'),
		(29, 31, '50 g'),

		(31, 40, null),

		(32, 28, '15 g'),

		(33, 37, null),
		(33, 33, '10 g'); 
-- SELECT * FROM PassoIngrediente;
-- Delete from PassoIngrediente;


Insert into ReceitaIngrediente (id_receita, id_ingrediente, quantidade)
	VALUES
		(1, 1, '800 ml'),
		(1, 2, '125 g'),
		(1, 3, '200 g'),
		(1, 4, '600 g'),
		(1, 5, '4 unidades'),
		(1, 6, '1 colher de sopa'),
		(1, 7, '4 unidades'),
		(1, 8, '1 colher de ch�'),
		(1, 9, '1 unidade'),
		(1, 10, '1 colher de caf�'),
		(1, 11, '1 unidade'),
		(1, 12, '20 g'),
		(1, 13, '100 g'),
		(1, 14, '10 g'),
		
		(2, 1, '6 ch�venas'),
		(2, 26, '1 unidade'),
		(2, 27, '1 unidade'),
		(2, 28, '30 g'),
		(2, 29, '2 colheres de sopa'),
		(2, 30, '10 unidades'),
		(2, 3, '200 g'),
		(2, 31, '50 g'),
		(2, 32, '1 colher de caf�'),
		(2, 8, '1 colher de ch�'),
		(2, 33, '10 g');
-- SELECT * FROM ReceitaIngrediente;
-- Delete from ReceitaIngrediente;


Insert into ReceitaPasso (id_passo, id_receita, numero)
	VALUES
		(1, 1, 1),
		(2, 1, 2),
		(3, 1, 3),
		(4, 1, 4),
		(5, 1, 5),
		(6, 1, 6),
		(7, 1, 7),
		(8, 1, 8),
		(9, 1, 9),
		(10, 1, 10),
		(11, 1, 11),
		(12, 1, 12),
		(13, 1, 13),
		(14, 1, 14),
		(15, 1, 15),
		(16, 1, 16),
		(17, 1, 17),
		(18, 1, 18),
		
		(19, 2, 1),
		(20, 2, 2),
		(21, 2, 3),
		(22, 2, 4),
		(23, 2, 5),
		(24, 2, 6),
		(25, 2, 7),
		(26, 2, 8),
		(27, 2, 9),
		(28, 2, 10),
		(29, 2, 11),
		(30, 2, 12),
		(31, 2, 13),
		(32, 2, 14),
		(33, 2, 15);
-- SELECT * FROM ReceitaPasso;
-- Delete from ReceitaPasso;


select * from IngredientePreferidoUtilizador;