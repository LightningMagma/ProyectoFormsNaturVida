CREATE DATABASE  IF NOT EXISTS `naturvida` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `naturvida`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: naturvida
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `cliDocumento` int NOT NULL,
  `cliNombre` varchar(45) DEFAULT NULL,
  `CliDireccion` varchar(45) DEFAULT NULL,
  `cliTelefono` varchar(45) DEFAULT NULL,
  `cliCorreo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cliDocumento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1001,'Juan','Calle 26','455520152','jas@gmail.com');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturadetalle`
--

DROP TABLE IF EXISTS `facturadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturadetalle` (
  `idFacturaDetalle` int NOT NULL AUTO_INCREMENT,
  `facNumero` int DEFAULT NULL,
  `facProducto` int DEFAULT NULL,
  `facCantidad` int DEFAULT NULL,
  PRIMARY KEY (`idFacturaDetalle`),
  KEY `fkFactura_idx` (`facNumero`),
  KEY `fkProducto_idx` (`facProducto`),
  CONSTRAINT `fkFactura` FOREIGN KEY (`facNumero`) REFERENCES `facturas` (`facNumero`),
  CONSTRAINT `fkProducto` FOREIGN KEY (`facProducto`) REFERENCES `productos` (`proCodigo`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturadetalle`
--

LOCK TABLES `facturadetalle` WRITE;
/*!40000 ALTER TABLE `facturadetalle` DISABLE KEYS */;
INSERT INTO `facturadetalle` VALUES (16,1,789,45),(18,1,789,46),(22,3,789,3),(23,7,789,8),(24,7,789,45),(25,7,789,45),(26,7,789,45),(27,2,789,4),(28,2,789,4),(29,2,789,4),(32,2,789,2),(33,456,789,2),(34,3,789,798),(35,69,789,69),(36,1,1,1),(37,1,2,2);
/*!40000 ALTER TABLE `facturadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturas`
--

DROP TABLE IF EXISTS `facturas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturas` (
  `facNumero` int NOT NULL,
  `facCliente` int DEFAULT NULL,
  `facValorTotal` double DEFAULT NULL,
  `facVendedor` int DEFAULT NULL,
  `fecha` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`facNumero`),
  KEY `fkCliente_idx` (`facCliente`),
  KEY `fkVendedor_idx` (`facVendedor`),
  CONSTRAINT `fkCliente` FOREIGN KEY (`facCliente`) REFERENCES `clientes` (`cliDocumento`),
  CONSTRAINT `fkVendedor` FOREIGN KEY (`facVendedor`) REFERENCES `vendedores` (`venId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturas`
--

LOCK TABLES `facturas` WRITE;
/*!40000 ALTER TABLE `facturas` DISABLE KEYS */;
INSERT INTO `facturas` VALUES (1,1001,71804,NULL,'24/08/2020'),(2,1001,11046,NULL,'31 de agosto de 2022'),(3,1001,631989,NULL,'31 de agosto de 2022'),(7,1001,112827,NULL,'31 de agosto de 2022'),(69,1001,54441,NULL,'31 de agosto de 2022'),(456,1001,1578,NULL,'31 de agosto de 2022');
/*!40000 ALTER TABLE `facturas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `proCodigo` int NOT NULL,
  `proNombre` varchar(45) DEFAULT NULL,
  `proDescripcion` varchar(150) DEFAULT NULL,
  `proValor` double DEFAULT NULL,
  `proCantidad` int DEFAULT NULL,
  PRIMARY KEY (`proCodigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'1','1',1,1),(2,'2','2',2,2),(789,'789','789',789,789);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendedores`
--

DROP TABLE IF EXISTS `vendedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vendedores` (
  `venId` int NOT NULL AUTO_INCREMENT,
  `venUsuario` varchar(45) DEFAULT NULL,
  `venContraseña` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`venId`),
  UNIQUE KEY `venUsuario_UNIQUE` (`venUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendedores`
--

LOCK TABLES `vendedores` WRITE;
/*!40000 ALTER TABLE `vendedores` DISABLE KEYS */;
INSERT INTO `vendedores` VALUES (1,'Juan','123'),(2,'Miguel','1234');
/*!40000 ALTER TABLE `vendedores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-01  2:01:56
