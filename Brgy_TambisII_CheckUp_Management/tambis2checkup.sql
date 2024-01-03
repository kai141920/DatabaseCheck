-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Jan 02, 2024 at 11:14 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tambis2checkup`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

CREATE TABLE `appointment` (
  `residentid` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL,
  `gender` enum('male','female') NOT NULL,
  `age` int(11) NOT NULL,
  `dateofbirth` date DEFAULT NULL,
  `status` enum('Single','Married','Annulled','Widowed') NOT NULL,
  `contactno` varchar(15) NOT NULL,
  `emailaddress` varchar(100) DEFAULT NULL,
  `statusA` enum('0','1','2') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`residentid`, `firstname`, `middlename`, `lastname`, `gender`, `age`, `dateofbirth`, `status`, `contactno`, `emailaddress`, `statusA`) VALUES
(1, 'Jade', 'Kyle', 'Berondo', 'male', 20, '2023-12-20', 'Single', '09455364167', 'jemerson@gmail.com', '2'),
(2, 'Jade', 'Kyle', 'Berondo', 'male', 20, '2023-12-20', 'Married', '09455364167', 'jemerson@gmail.com', '1'),
(3, 'Jerold', 'Acampado', 'Mernilo', 'male', 19, '2004-12-20', 'Single', '09161974946', 'mill@gmail.com', '1'),
(4, 'Leah', 'Ignacio', 'Rufin', 'male', 21, '2023-12-20', 'Married', '09151967246', 'yang@gmail.com', '1'),
(5, 'jerald', 'acampado', 'mernilo', 'male', 20, '2023-12-20', 'Single', '09732416327', 'jemerson@gmail.com', '1');

-- --------------------------------------------------------

--
-- Table structure for table `checkup`
--

CREATE TABLE `checkup` (
  `id` int(11) NOT NULL,
  `patientid` int(11) NOT NULL,
  `date` date NOT NULL,
  `bloodpressure` enum('None','Low Blood','High Blood') DEFAULT NULL,
  `coldfever` enum('None','Flu','Polio','Common Cold','Dengue Fever') DEFAULT NULL,
  `animalbite` enum('None','Dog Bite','Snake Bite','Cat Bite','Bee Bite') DEFAULT NULL,
  `skindiseases` enum('None','Chicken Pox','Syphilis','Contusion','Tigdas') DEFAULT NULL,
  `othersymptoms` enum('None','Diarrhea','Sore Eyes','Asthma','Sore Throat','Dehydration') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `checkup`
--

INSERT INTO `checkup` (`id`, `patientid`, `date`, `bloodpressure`, `coldfever`, `animalbite`, `skindiseases`, `othersymptoms`) VALUES
(5, 1, '2023-12-20', 'None', 'Common Cold', 'Dog Bite', 'None', 'Sore Throat'),
(6, 1, '2023-12-20', 'None', 'Polio', 'None', 'Tigdas', 'None'),
(7, 2, '2023-12-20', 'None', 'None', 'None', 'Syphilis', 'Diarrhea'),
(8, 3, '2023-12-20', 'None', 'Flu', 'Cat Bite', 'None', 'None'),
(9, 3, '2023-12-20', 'None', 'Polio', 'None', 'Chicken Pox', 'None'),
(10, 4, '2023-12-20', 'Low Blood', 'None', 'Snake Bite', 'None', 'Diarrhea'),
(11, 5, '2023-12-20', 'None', 'Common Cold', 'Dog Bite', 'None', 'None'),
(12, 5, '2023-12-20', 'None', 'Common Cold', 'Dog Bite', 'None', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`residentid`);

--
-- Indexes for table `checkup`
--
ALTER TABLE `checkup`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `checkup`
--
ALTER TABLE `checkup`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
