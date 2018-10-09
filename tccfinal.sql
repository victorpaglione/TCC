-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 08-Out-2018 às 13:51
-- Versão do servidor: 10.1.13-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tccfinal`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `avaliacao`
--

CREATE TABLE `avaliacao` (
  `cod_ava` int(11) NOT NULL,
  `avaliacao` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `avaliacao`
--

INSERT INTO `avaliacao` (`cod_ava`, `avaliacao`) VALUES
(1, 'bom'),
(2, 'medio'),
(3, 'ruim');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `Cod_cliente` int(11) NOT NULL,
  `nome_cliente` varchar(50) NOT NULL,
  `tipo_pessoa` int(11) NOT NULL,
  `cpf_cnpj` int(14) NOT NULL,
  `tel_fixo` int(10) NOT NULL,
  `tel_cel` int(11) NOT NULL,
  `email_cliete` varchar(40) NOT NULL,
  `UF` int(11) NOT NULL,
  `cidade` varchar(30) NOT NULL,
  `cep_cliente` int(8) NOT NULL,
  `endereco_cliente` varchar(50) NOT NULL,
  `avaliacao_cliente` int(11) NOT NULL,
  `orcamentos_feitos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`Cod_cliente`, `nome_cliente`, `tipo_pessoa`, `cpf_cnpj`, `tel_fixo`, `tel_cel`, `email_cliete`, `UF`, `cidade`, `cep_cliente`, `endereco_cliente`, `avaliacao_cliente`, `orcamentos_feitos`) VALUES
(1, 'Andressa Milna', 1, 121242535, 12312313, 1212321, 'vsuvidsv@aiuhfaisu.com', 1, 'Hortolandia', 13184210, 'asfdsdgahgasas', 2, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `estado`
--

CREATE TABLE `estado` (
  `cod_estao` int(11) NOT NULL,
  `estado` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `estado`
--

INSERT INTO `estado` (`cod_estao`, `estado`) VALUES
(1, 'SP'),
(2, 'MG'),
(3, 'RJ');

-- --------------------------------------------------------

--
-- Estrutura da tabela `metodo_pag`
--

CREATE TABLE `metodo_pag` (
  `cod_metodo` int(11) NOT NULL,
  `m_pag` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `metodo_pag`
--

INSERT INTO `metodo_pag` (`cod_metodo`, `m_pag`) VALUES
(3, 'A vista');

-- --------------------------------------------------------

--
-- Estrutura da tabela `orcamentos`
--

CREATE TABLE `orcamentos` (
  `cod_orca` int(11) NOT NULL,
  `data_orca` date NOT NULL,
  `valor_orca` double NOT NULL,
  `cliente` int(11) NOT NULL,
  `data_entrega` date NOT NULL,
  `status_orca` int(11) NOT NULL,
  `ano_id` int(11) NOT NULL,
  `mes_id` int(11) NOT NULL,
  `dia_id` int(11) NOT NULL,
  `metodo_pag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `orcamentos`
--

INSERT INTO `orcamentos` (`cod_orca`, `data_orca`, `valor_orca`, `cliente`, `data_entrega`, `status_orca`, `ano_id`, `mes_id`, `dia_id`, `metodo_pag`) VALUES
(3, '2018-10-08', 1233, 1, '2018-10-31', 1, 2018, 10, 8, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

CREATE TABLE `servico` (
  `cod_orca` int(11) NOT NULL,
  `cod_servico` int(11) NOT NULL,
  `valor_serviço` double NOT NULL,
  `desc_serv` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `status`
--

CREATE TABLE `status` (
  `cod_status` int(11) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `status`
--

INSERT INTO `status` (`cod_status`, `status`) VALUES
(1, 'aberto'),
(2, 'fechado');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo_pessoa`
--

CREATE TABLE `tipo_pessoa` (
  `cod_tipo_pessoa` int(11) NOT NULL,
  `tipo_pessoa` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tipo_pessoa`
--

INSERT INTO `tipo_pessoa` (`cod_tipo_pessoa`, `tipo_pessoa`) VALUES
(1, 'fisica'),
(2, 'juridica');

-- --------------------------------------------------------

--
-- Estrutura da tabela `user`
--

CREATE TABLE `user` (
  `cod_user` int(11) NOT NULL,
  `Login` varchar(30) NOT NULL,
  `Senha` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `user`
--

INSERT INTO `user` (`cod_user`, `Login`, `Senha`) VALUES
(1, 'aa', 'ss');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `avaliacao`
--
ALTER TABLE `avaliacao`
  ADD PRIMARY KEY (`cod_ava`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Cod_cliente`),
  ADD KEY `fk_pessoa` (`tipo_pessoa`),
  ADD KEY `fk_uf` (`UF`),
  ADD KEY `fk_ava` (`avaliacao_cliente`);

--
-- Indexes for table `estado`
--
ALTER TABLE `estado`
  ADD PRIMARY KEY (`cod_estao`);

--
-- Indexes for table `metodo_pag`
--
ALTER TABLE `metodo_pag`
  ADD PRIMARY KEY (`cod_metodo`);

--
-- Indexes for table `orcamentos`
--
ALTER TABLE `orcamentos`
  ADD PRIMARY KEY (`cod_orca`),
  ADD KEY `fk_metodo_pag` (`metodo_pag`),
  ADD KEY `fk_cliente` (`cliente`),
  ADD KEY `fk_status` (`status_orca`);

--
-- Indexes for table `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`cod_servico`,`cod_orca`);

--
-- Indexes for table `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`cod_status`);

--
-- Indexes for table `tipo_pessoa`
--
ALTER TABLE `tipo_pessoa`
  ADD PRIMARY KEY (`cod_tipo_pessoa`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`cod_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `avaliacao`
--
ALTER TABLE `avaliacao`
  MODIFY `cod_ava` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `Cod_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `estado`
--
ALTER TABLE `estado`
  MODIFY `cod_estao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `metodo_pag`
--
ALTER TABLE `metodo_pag`
  MODIFY `cod_metodo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `orcamentos`
--
ALTER TABLE `orcamentos`
  MODIFY `cod_orca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `servico`
--
ALTER TABLE `servico`
  MODIFY `cod_servico` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `status`
--
ALTER TABLE `status`
  MODIFY `cod_status` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tipo_pessoa`
--
ALTER TABLE `tipo_pessoa`
  MODIFY `cod_tipo_pessoa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `cod_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `fk_ava` FOREIGN KEY (`avaliacao_cliente`) REFERENCES `avaliacao` (`cod_ava`),
  ADD CONSTRAINT `fk_pessoa` FOREIGN KEY (`tipo_pessoa`) REFERENCES `tipo_pessoa` (`cod_tipo_pessoa`),
  ADD CONSTRAINT `fk_uf` FOREIGN KEY (`UF`) REFERENCES `estado` (`cod_estao`);

--
-- Limitadores para a tabela `orcamentos`
--
ALTER TABLE `orcamentos`
  ADD CONSTRAINT `fk_cliente` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`Cod_cliente`),
  ADD CONSTRAINT `fk_metodo_pag` FOREIGN KEY (`metodo_pag`) REFERENCES `metodo_pag` (`cod_metodo`),
  ADD CONSTRAINT `fk_status` FOREIGN KEY (`status_orca`) REFERENCES `status` (`cod_status`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
