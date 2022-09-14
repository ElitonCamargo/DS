-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 13-Set-2022 às 21:26
-- Versão do servidor: 8.0.27
-- versão do PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `loja`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `filme`
--

DROP TABLE IF EXISTS `filme`;
CREATE TABLE IF NOT EXISTS `filme` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `ano` int DEFAULT NULL,
  `avaliacao` int DEFAULT NULL,
  `like` tinyint(1) DEFAULT NULL,
  `comentario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `filme`
--

INSERT INTO `filme` (`id`, `nome`, `ano`, `avaliacao`, `like`, `comentario`) VALUES
(1, '1', 3, 2, 0, 'fsdfd'),
(2, '1', 1, 5, 1, 'fsdfsd'),
(3, '3', 5, 5, 1, 'asdfds'),
(4, 't', 4, 5, 1, 'sdafsd');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `Codigo` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Valor` double NOT NULL,
  `Quantidade` int NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`Codigo`, `Nome`, `Valor`, `Quantidade`) VALUES
(11, 'Bola Adidas', 99.00000000000001, 10),
(12, 'Tenis Nike Air force', 593.9901000000001, 100),
(13, 'Chuteira Adidas', 295.5645, 5),
(14, 'Chuteira Nike', 394.5645, 15),
(15, 'Bola Nike', 226.26450000000003, 10),
(16, 'Chuteira Adidas', 295.5645, 5),
(17, 'Chuteira Nike', 394.5645, 15),
(18, 'Bola Nike', 226.26450000000003, 10),
(19, 'Chuteira Adidas', 295.5645, 5),
(20, 'Chuteira Nike', 394.5645, 15),
(21, 'Bola Nike', 226.26450000000003, 10),
(22, 'Luva bike', 59.390100000000004, 100),
(23, 'bike CBX', 1940.3901, 10),
(24, 'ProdutoX CBX', 455.3901, 10),
(25, 'Luva box', 405.8901, 8),
(26, 'Saco de pancada', 297.98010000000005, 5);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
