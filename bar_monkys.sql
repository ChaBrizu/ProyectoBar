-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 26-11-2018 a las 17:48:21
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bar_monkys`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(15) NOT NULL,
  `apellido` varchar(15) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `deuda` float NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_cliente`, `nombre`, `apellido`, `direccion`, `telefono`, `deuda`) VALUES
(1, 'Rafael', 'Reyes', 'Avenida México S/N Colonia Benito Juarez Cd. Sahagun', '7751454067', 150.5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` int(10) NOT NULL AUTO_INCREMENT,
  `nom_producto` varchar(30) NOT NULL,
  `cantidad` int(15) NOT NULL,
  `precio` float NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=123410 ;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id_producto`, `nom_producto`, `cantidad`, `precio`, `descripcion`) VALUES
(1, 'Cerveza Corona', 100, 17, 'Cerveza marca corona'),
(2, 'Cerveza Tecate Light', 100, 17.5, 'cerveza light marca tecate'),
(3, 'Cerveza Tecate Titanium', 100, 20, 'cerveza con el doble de grados de alcohol de la ma'),
(4, 'Jack Daniels', 100, 200, 'Botella de Wiskey'),
(5, 'Red Label JW', 100, 250, 'Botella de wiskey'),
(6, 'Cerveza Modelo Negra', 100, 17.5, 'cerveza negra marca modelo'),
(7, 'Cerveza Modelo', 100, 17, 'cerveza clara de la marca modelo'),
(1234, 'Cerveza Tecate', 100, 17.5, 'cerveza marca tecate'),
(12345, 'Cerveza Indio', 100, 15.5, 'cerveza de  la marca'),
(102039, 'Oso Negro', 100, 190, 'Vodka de la marca oso negro'),
(123409, 'Barcardi Blanco', 100, 170, 'Ron blanco de la marca bacardi');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id_user` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `contraseña` varchar(20) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_user`, `nombre`, `contraseña`) VALUES
(1, 'Emmanuel', '12345'),
(2, 'Carlos', '1234');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
