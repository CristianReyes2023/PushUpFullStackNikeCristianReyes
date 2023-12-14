CREATE DATABASE nikedb;
USE nikedb;

CREATE TABLE `user` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `username` varchar(50) UNIQUE NOT NULL,
  `password` varchar(150) UNIQUE NOT NULL,
  `email` varchar(100) UNIQUE NOT NULL
);

CREATE TABLE `rol` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) UNIQUE NOT NULL
);

CREATE TABLE `userrol` (
  `id_user_fk` int NOT NULL,
  `id_rol_fk` int NOT NULL,
  PRIMARY KEY (`id_user_fk`, `id_rol_fk`)
);

CREATE TABLE `pais` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) UNIQUE
);

CREATE TABLE `departamento` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) UNIQUE,
  `id_pais_fk` int NOT NULL
);

CREATE TABLE `ciudad` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) UNIQUE,
  `id_departamento_fk` int NOT NULL
);

CREATE TABLE `direccion` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `tipo_via` varchar(50),
  `numero_principal` smallint,
  `letra_principal` char(2),
  `bis` char(10),
  `letra_secundaria` char(2),
  `cardinal_primario` char(10),
  `numero_secundario` smallint,
  `cardinal_secundario` char(10),
  `complemento` varchar(50),
  `id_ciudad_fk` int
);

CREATE TABLE `cliente` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `id_persona` int UNIQUE,
  `nombre` varchar(50),
  `apellido` varchar(50),
  `email` varchar(50),
  `telefono` int,
  `id_direccion_fk` int
);


CREATE TABLE `producto` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50),
  `imagen` varchar(200),
  `talla` varchar(5),
  `stock_min` int,
  `stock_actual` int,
  `stock_max` int,
  `precio` double,
  `id_tipo_producto_fk` int
);

CREATE TABLE `tipo_producto` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50)
);

CREATE TABLE `pago` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `fecha_pago` date,
  `total` int,
  `id_forma_pago_fk` int
);

CREATE TABLE `pedido` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT
  `id_pago_fk` int,
  `id_cliente_fk` int
);

CREATE TABLE `forma_pago` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50)
);

CREATE TABLE `orden_pedido` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `id_orden_fk` int,
  `id_pedido_fk` int
);

CREATE TABLE `estado` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50)
);

CREATE TABLE `orden` (
  `id` int UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `cantidad` int,
  `id_producto_fk` int
);

ALTER TABLE `userrol` ADD FOREIGN KEY (`id_user_fk`) REFERENCES `user` (`id`);

ALTER TABLE `userrol` ADD FOREIGN KEY (`id_rol_fk`) REFERENCES `rol` (`id`);

ALTER TABLE `departamento` ADD FOREIGN KEY (`id_pais_fk`) REFERENCES `pais` (`id`);

ALTER TABLE `ciudad` ADD FOREIGN KEY (`id_departamento_fk`) REFERENCES `departamento` (`id`);

ALTER TABLE `direccion` ADD FOREIGN KEY (`id_ciudad_fk`) REFERENCES `ciudad` (`id`);

ALTER TABLE `cliente` ADD FOREIGN KEY (`id_direccion_fk`) REFERENCES `direccion` (`id`);

ALTER TABLE `producto` ADD FOREIGN KEY (`id_tipo_producto_fk`) REFERENCES `tipo_producto` (`id`);

ALTER TABLE `pago` ADD FOREIGN KEY (`id_forma_pago_fk`) REFERENCES `forma_pago` (`id`);

ALTER TABLE `orden_pedido` ADD FOREIGN KEY (`id_orden_fk`) REFERENCES `orden` (`id`);

ALTER TABLE `orden_pedido` ADD FOREIGN KEY (`id_pedido_fk`) REFERENCES `pedido` (`id`);

ALTER TABLE `pedido` ADD FOREIGN KEY (`id_cliente_fk`) REFERENCES `cliente` (`id`);

ALTER TABLE `pedido` ADD FOREIGN KEY (`id_pago_fk`) REFERENCES `pago` (`id`);

ALTER TABLE `orden` ADD FOREIGN KEY (`id_producto_fk`) REFERENCES `producto` (`id`);


-- DATOS

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20231214142413_FirstMigration','7.0.13'),('20231214170109_SecondMigration','7.0.13');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,'Bucaramanga',1),(2,'Arauca',2),(3,'Barranquilla',3),(4,'Chia',4);
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,1234,'Jose','Perez','perez@',3216,1),(2,2134,'Orlando','Acevedo','orlando@',4561,2),(3,3145,'Maria','Martinez','maria@',2153,3);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Santander',1),(2,'Arauca',1),(3,'Atlantico',1),(4,'Cundinamarca',1);
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
INSERT INTO `direccion` VALUES (1,'Calle',34,'A',NULL,NULL,NULL,NULL,NULL,'Barrio Porto',1),(2,'Avenida ',23,NULL,'B','C',NULL,NULL,NULL,'Barrio Candelaria',2),(3,'Calle ',67,'B','',NULL,NULL,NULL,NULL,'Barrio La Arenosa',3),(4,'Carrera ',89,'A','D',NULL,NULL,NULL,NULL,'Conjunto Ventura',4);
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `forma_pago`
--

LOCK TABLES `forma_pago` WRITE;
/*!40000 ALTER TABLE `forma_pago` DISABLE KEYS */;
INSERT INTO `forma_pago` VALUES (1,'PSE'),(2,'PAYPAL'),(3,'EFECTY'),(4,'NEQUI');
/*!40000 ALTER TABLE `forma_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `orden`
--

LOCK TABLES `orden` WRITE;
/*!40000 ALTER TABLE `orden` DISABLE KEYS */;
INSERT INTO `orden` VALUES (1,1,1),(2,2,2),(3,3,3),(4,1,4),(5,3,5),(6,2,6),(7,2,7),(8,1,8),(9,3,9);
/*!40000 ALTER TABLE `orden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `orden_pedido`
--

LOCK TABLES `orden_pedido` WRITE;
/*!40000 ALTER TABLE `orden_pedido` DISABLE KEYS */;
INSERT INTO `orden_pedido` VALUES (1,2,3),(2,1,1),(3,8,2),(4,4,3),(5,1,2),(6,3,3),(7,5,1),(8,6,2),(9,7,1);
/*!40000 ALTER TABLE `orden_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
INSERT INTO `pago` VALUES (1,'2023-12-10',440000,1),(2,'2023-11-25',40000,2),(3,'2023-08-25',420000,3);
/*!40000 ALTER TABLE `pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pais`
--

LOCK TABLES `pais` WRITE;
/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
INSERT INTO `pais` VALUES (1,'Colombia'),(3,'EEUU'),(4,'España'),(2,'Mexico'),(5,'Peru');
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,1,1),(2,2,2),(3,3,3);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Abrigo Retro',NULL,'L',10,23,50,120000,1),(2,'Abrigo Invierto',NULL,'M',5,25,40,140000,1),(3,'Abrigo Acolchada',NULL,'S',15,20,40,150000,1),(4,'CamisetaMagaCorta',NULL,'L',25,40,90,70000,2),(5,'CamisetaCuelloV',NULL,'M',20,45,80,70000,2),(6,'CamisetaSinMangas',NULL,'XL',15,35,50,70000,2),(7,'PantalonVaqueros',NULL,'34',10,35,50,250000,3),(8,'PantalonTela',NULL,'36',5,20,30,190000,3),(9,'PantalonSlim',NULL,'32',10,26,35,200000,3);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tipo_producto`
--

LOCK TABLES `tipo_producto` WRITE;
/*!40000 ALTER TABLE `tipo_producto` DISABLE KEYS */;
INSERT INTO `tipo_producto` VALUES (1,'Abrigos'),(2,'Camisetas'),(3,'Pantalones');
/*!40000 ALTER TABLE `tipo_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `userrol`
--

LOCK TABLES `userrol` WRITE;
/*!40000 ALTER TABLE `userrol` DISABLE KEYS */;
/*!40000 ALTER TABLE `userrol` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-14 12:17:08
