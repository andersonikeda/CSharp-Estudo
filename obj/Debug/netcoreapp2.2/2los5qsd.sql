CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Clientes` (
    `ClienteId` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(50) NULL,
    `Email` varchar(80) NULL,
    CONSTRAINT `PK_Clientes` PRIMARY KEY (`ClienteId`)
);

CREATE TABLE `Produto` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Descricao` varchar(50) NULL,
    `Unidade` varchar(2) NULL,
    `Custo` decimal(12,2) NOT NULL,
    `Preco` decimal(12,2) NOT NULL,
    `CodigoDeBarras` varchar(13) NULL,
    `Estoque` decimal(12,3) NOT NULL,
    CONSTRAINT `PK_Produto` PRIMARY KEY (`Id`)
);

CREATE TABLE `Vendas` (
    `VendaId` int NOT NULL AUTO_INCREMENT,
    `DataDaVenda` datetime(6) NOT NULL,
    `ClienteId` int NOT NULL,
    `DataPrevistaDaEntrega` datetime(6) NOT NULL,
    `CodigoDoRastreamento` varchar(20) NULL,
    CONSTRAINT `PK_Vendas` PRIMARY KEY (`VendaId`),
    CONSTRAINT `FK_Vendas_Clientes_ClienteId` FOREIGN KEY (`ClienteId`) REFERENCES `Clientes` (`ClienteId`) ON DELETE CASCADE
);

CREATE TABLE `VendaItens` (
    `VendaItensId` int NOT NULL AUTO_INCREMENT,
    `VendaId` int NOT NULL,
    `ProdutoId` int NOT NULL,
    `Quantidade` int NOT NULL,
    `ValorDeVenda` decimal(12,2) NOT NULL,
    CONSTRAINT `PK_VendaItens` PRIMARY KEY (`VendaItensId`),
    CONSTRAINT `FK_VendaItens_Produto_ProdutoId` FOREIGN KEY (`ProdutoId`) REFERENCES `Produto` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_VendaItens_Vendas_VendaId` FOREIGN KEY (`VendaId`) REFERENCES `Vendas` (`VendaId`) ON DELETE CASCADE
);

CREATE INDEX `IX_VendaItens_ProdutoId` ON `VendaItens` (`ProdutoId`);

CREATE INDEX `IX_VendaItens_VendaId` ON `VendaItens` (`VendaId`);

CREATE INDEX `IX_Vendas_ClienteId` ON `Vendas` (`ClienteId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201108002658_MigracaoInicial', '2.2.6-servicing-10079');

