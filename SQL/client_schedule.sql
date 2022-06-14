-- phpMyAdmin SQL Dump
-- version 4.9.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Feb 03, 2022 at 03:53 PM
-- Server version: 5.6.41-84.1
-- PHP Version: 7.3.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kenneue4_client_schedule`
--

DELIMITER $$
--
-- Procedures
--
$$

$$

--
-- Functions
--
$$

$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `address`
--

CREATE TABLE `address` (
  `addressId` int(11) NOT NULL,
  `address` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `address2` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `cityId` int(11) NOT NULL,
  `postalCode` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `createDate` datetime NOT NULL,
  `createdBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `address`
--

INSERT INTO `address` (`addressId`, `address`, `address2`, `cityId`, `postalCode`, `phone`, `createDate`, `createdBy`, `lastUpdate`, `lastUpdateBy`) VALUES
(1, '123 Main', '', 1, '11111', '555-1212', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(2, '123 Elm', '', 3, '11112', '555-1213', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(3, '123 Oak', '', 5, '11113', '555-1214', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(4, '123 Home St', 'apt 3', 6, '12801', '(518)-955-7089', '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test'),
(5, '123 Home St', 'apt 3', 7, '12801', '(518)-955-7089', '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

CREATE TABLE `appointment` (
  `appointmentId` int(11) NOT NULL,
  `customerId` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `title` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  `location` text COLLATE utf8_unicode_ci NOT NULL,
  `contact` text COLLATE utf8_unicode_ci NOT NULL,
  `type` text COLLATE utf8_unicode_ci NOT NULL,
  `url` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `start` datetime NOT NULL,
  `end` datetime NOT NULL,
  `createDate` datetime NOT NULL,
  `createdBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`appointmentId`, `customerId`, `userId`, `title`, `description`, `location`, `contact`, `type`, `url`, `start`, `end`, `createDate`, `createdBy`, `lastUpdate`, `lastUpdateBy`) VALUES
(1, 1, 1, 'not needed', 'not needed', 'not needed', 'not needed', 'Presentation', 'not needed', '2019-01-01 00:00:00', '2019-01-01 00:00:00', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(2, 2, 1, 'not needed', 'not needed', 'not needed', 'not needed', 'Scrum', 'not needed', '2019-01-01 00:00:00', '2019-01-01 00:00:00', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `city`
--

CREATE TABLE `city` (
  `cityId` int(11) NOT NULL,
  `city` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `countryId` int(11) NOT NULL,
  `createDate` datetime NOT NULL,
  `createdBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `city`
--

INSERT INTO `city` (`cityId`, `city`, `countryId`, `createDate`, `createdBy`, `lastUpdate`, `lastUpdateBy`) VALUES
(1, 'New York', 1, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(2, 'Los Angeles', 1, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(3, 'Toronto', 2, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(4, 'Vancouver', 2, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(5, 'Oslo', 3, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(6, 'Glens Falls', 4, '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test'),
(7, 'Glens Falls', 5, '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `country`
--

CREATE TABLE `country` (
  `countryId` int(11) NOT NULL,
  `country` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `createDate` datetime NOT NULL,
  `createdBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `country`
--

INSERT INTO `country` (`countryId`, `country`, `createDate`, `createdBy`, `lastUpdate`, `lastUpdateBy`) VALUES
(1, 'US', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(2, 'Canada', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(3, 'Norway', '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(4, 'USA', '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test'),
(5, 'USA', '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test'),
(6, 'Germany', '2022-02-03 00:00:00', 'klamb', '2022-02-03 07:00:00', 'klamb');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customerId` int(11) NOT NULL,
  `customerName` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `addressId` int(11) NOT NULL,
  `active` tinyint(1) NOT NULL,
  `createDate` datetime NOT NULL,
  `createdBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customerId`, `customerName`, `addressId`, `active`, `createDate`, `createdBy`, `lastUpdate`, `lastUpdateBy`) VALUES
(1, 'John Doe', 1, 1, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(2, 'Alfred E Newman', 2, 1, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(3, 'Ina Prufung', 3, 1, '2019-01-01 00:00:00', 'test', '2019-01-01 07:00:00', 'test'),
(4, 'Jane Doe', 5, 1, '2022-02-02 00:00:00', 'test', '2022-02-02 07:00:00', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userId` int(11) NOT NULL,
  `userName` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `active` tinyint(4) NOT NULL,
  `createDate` datetime NOT NULL,
  `createdBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userId`, `userName`, `password`, `active`, `createDate`, `createdBy`, `lastUpdate`, `lastUpdateBy`) VALUES
(1, 'test', 'n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=', 1, '2019-01-01 00:00:00', 'test', '2022-02-02 20:13:40', 'test');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `address`
--
ALTER TABLE `address`
  ADD PRIMARY KEY (`addressId`),
  ADD KEY `cityId` (`cityId`);

--
-- Indexes for table `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`appointmentId`),
  ADD KEY `userId` (`userId`),
  ADD KEY `appointment_ibfk_1` (`customerId`);

--
-- Indexes for table `city`
--
ALTER TABLE `city`
  ADD PRIMARY KEY (`cityId`),
  ADD KEY `countryId` (`countryId`);

--
-- Indexes for table `country`
--
ALTER TABLE `country`
  ADD PRIMARY KEY (`countryId`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customerId`),
  ADD KEY `addressId` (`addressId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `address`
--
ALTER TABLE `address`
  MODIFY `addressId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `appointment`
--
ALTER TABLE `appointment`
  MODIFY `appointmentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `city`
--
ALTER TABLE `city`
  MODIFY `cityId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `country`
--
ALTER TABLE `country`
  MODIFY `countryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `customerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `address`
--
ALTER TABLE `address`
  ADD CONSTRAINT `address_ibfk_1` FOREIGN KEY (`cityId`) REFERENCES `city` (`cityId`);

--
-- Constraints for table `appointment`
--
ALTER TABLE `appointment`
  ADD CONSTRAINT `appointment_ibfk_1` FOREIGN KEY (`customerId`) REFERENCES `customer` (`customerId`),
  ADD CONSTRAINT `appointment_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `user` (`userId`);

--
-- Constraints for table `city`
--
ALTER TABLE `city`
  ADD CONSTRAINT `city_ibfk_1` FOREIGN KEY (`countryId`) REFERENCES `country` (`countryId`);

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`addressId`) REFERENCES `address` (`addressId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
