CREATE DATABASE  IF NOT EXISTS `razpisanie` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `razpisanie`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: razpisanie
-- ------------------------------------------------------
-- Server version	8.0.36

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
-- Table structure for table `firmi`
--

DROP TABLE IF EXISTS `firmi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `firmi` (
  `id_firma` int NOT NULL AUTO_INCREMENT,
  `ime` varchar(40) NOT NULL,
  PRIMARY KEY (`id_firma`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `firmi`
--

LOCK TABLES `firmi` WRITE;
/*!40000 ALTER TABLE `firmi` DISABLE KEYS */;
INSERT INTO `firmi` VALUES (1,'Arsenal'),(2,'Metro Transit'),(3,'Urban Express'),(4,'City Cruiser'),(5,'Metro Movers'),(6,'Metro Transit'),(7,'Metro Transit');
/*!40000 ALTER TABLE `firmi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rarzpisaniq`
--

DROP TABLE IF EXISTS `rarzpisaniq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rarzpisaniq` (
  `id_marshrut` int NOT NULL AUTO_INCREMENT,
  `zaminava_ot` varchar(40) NOT NULL,
  `pristiga_v` varchar(40) NOT NULL,
  `chas_pristigane` time NOT NULL,
  `chas_zaminavane` time NOT NULL,
  PRIMARY KEY (`id_marshrut`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rarzpisaniq`
--

LOCK TABLES `rarzpisaniq` WRITE;
/*!40000 ALTER TABLE `rarzpisaniq` DISABLE KEYS */;
INSERT INTO `rarzpisaniq` VALUES (4,'Sofia','Varna','12:45:00','20:45:00'),(5,'Plovdiv ','Burgas ','10:30:00','17:30:00'),(6,'Veliko Tarnovo ','Blagoevgrad  ','11:15:00','18:15:00'),(7,'Ruse','Stara Zagora','09:55:00','16:55:00'),(8,'Pleven ','Gabrovo ','08:40:00','15:40:00'),(9,'Haskovo  ','Dobrich  ','14:20:00','21:20:00'),(10,'Shumen   ','Sliven   ','13:10:00','20:10:00'),(11,'Pazardzhik','Vidin','10:05:00','17:05:00'),(12,'Montana ','Yambol ','12:25:00','19:26:00'),(13,'Kyustendil','Silistra','11:50:00','18:50:00');
/*!40000 ALTER TABLE `rarzpisaniq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `razpisaniq_firmi`
--

DROP TABLE IF EXISTS `razpisaniq_firmi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `razpisaniq_firmi` (
  `id_marshrut` int NOT NULL,
  `id_firma` int NOT NULL,
  KEY `PK_firmi` (`id_firma`),
  KEY `PK_razpisaniq` (`id_marshrut`),
  CONSTRAINT `PK_firmi` FOREIGN KEY (`id_firma`) REFERENCES `firmi` (`id_firma`),
  CONSTRAINT `PK_razpisaniq` FOREIGN KEY (`id_marshrut`) REFERENCES `rarzpisaniq` (`id_marshrut`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `razpisaniq_firmi`
--

LOCK TABLES `razpisaniq_firmi` WRITE;
/*!40000 ALTER TABLE `razpisaniq_firmi` DISABLE KEYS */;
INSERT INTO `razpisaniq_firmi` VALUES (4,1),(5,2),(6,3),(7,4),(8,5),(9,1),(10,2),(11,3),(12,4),(13,5);
/*!40000 ALTER TABLE `razpisaniq_firmi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'razpisanie'
--

--
-- Dumping routines for database 'razpisanie'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-03-06  0:07:24
