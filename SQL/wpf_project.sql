-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Máj 29. 18:17
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.1.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `wpf_project`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cars`
--

CREATE TABLE `cars` (
  `carid` int(11) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `plate` varchar(10) NOT NULL,
  `km` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `cars`
--

INSERT INTO `cars` (`carid`, `brand`, `type`, `plate`, `km`) VALUES
(1, 'Opel', 'Vivaro', 'DHL-001', 108665),
(2, 'Mercedes-Benz', 'Crafter', 'DHL-002', 325582),
(3, 'Mercedes-Benz', 'Crafter', 'DHL-003', 11910),
(4, 'Opel', 'Vivaro', 'DHL-004', 32807),
(5, 'Mercedes-Benz', 'Citan', 'DHL-005', 118305),
(6, 'Opel', 'Vivaro', 'DHL-006', 163105),
(7, 'Opel', 'Vivaro', 'DHL-007', 130609),
(8, 'Mercedes-Benz', 'Citan', 'DHL-008', 153729),
(9, 'Opel', 'Vivaro', 'DHL-009', 46820),
(10, 'Mercedes-Benz', 'Crafter', 'DHL-010', 82916),
(11, 'Opel', 'Vivaro', 'DHL-011', 264117),
(12, 'Mercedes-Benz', 'Crafter', 'DHL-012', 101836),
(13, 'Mercedes-Benz', 'Crafter', 'DHL-013', 26829),
(14, 'Opel', 'Vivaro', 'DHL-014', 138640),
(15, 'Mercedes-Benz', 'Citan', 'DHL-015', 282711),
(16, 'Opel', 'Vivaro', 'DHL-016', 27634),
(17, 'Opel', 'Vivaro', 'DHL-017', 240038),
(18, 'Mercedes-Benz', 'Citan', 'DHL-018', 147288),
(19, 'Opel', 'Vivaro', 'DHL-019', 326328),
(20, 'Mercedes-Benz', 'Crafter', 'DHL-020', 219772),
(21, 'Opel', 'Vivaro', 'DHL-021', 109876),
(22, 'Mercedes-Benz', 'Crafter', 'DHL-022', 200064),
(23, 'Mercedes-Benz', 'Crafter', 'DHL-023', 20694),
(24, 'Opel', 'Vivaro', 'DHL-024', 133280),
(25, 'Mercedes-Benz', 'Citan', 'DHL-025', 274316),
(26, 'Opel', 'Vivaro', 'DHL-026', 321741),
(27, 'Opel', 'Vivaro', 'DHL-027', 135755),
(28, 'Mercedes-Benz', 'Citan', 'DHL-028', 23553),
(29, 'Opel', 'Vivaro', 'DHL-029', 20500),
(30, 'Mercedes-Benz', 'Crafter', 'DHL-030', 21844),
(31, 'Opel', 'Vivaro', 'DHL-031', 37720),
(32, 'Mercedes-Benz', 'Crafter', 'DHL-032', 113066),
(33, 'Mercedes-Benz', 'Crafter', 'DHL-033', 122172),
(34, 'Opel', 'Vivaro', 'DHL-034', 261662),
(35, 'Mercedes-Benz', 'Citan', 'DHL-035', 291794),
(36, 'Opel', 'Vivaro', 'DHL-036', 23980),
(37, 'Opel', 'Vivaro', 'DHL-037', 194523),
(38, 'Mercedes-Benz', 'Citan', 'DHL-038', 250673),
(39, 'Opel', 'Vivaro', 'DHL-039', 19794),
(40, 'Mercedes-Benz', 'Crafter', 'DHL-040', 296956),
(41, 'Opel', 'Vivaro', 'DHL-041', 135392),
(42, 'Mercedes-Benz', 'Crafter', 'DHL-042', 96095),
(43, 'Mercedes-Benz', 'Crafter', 'DHL-043', 64299),
(44, 'Opel', 'Vivaro', 'DHL-044', 23211),
(45, 'Mercedes-Benz', 'Citan', 'DHL-045', 233158),
(46, 'Opel', 'Vivaro', 'DHL-046', 126154),
(47, 'Opel', 'Vivaro', 'DHL-047', 241298),
(48, 'Mercedes-Benz', 'Citan', 'DHL-048', 178028),
(49, 'Opel', 'Vivaro', 'DHL-049', 156245),
(50, 'Mercedes-Benz', 'Crafter', 'DHL-050', 237140),
(51, 'Opel', 'Vivaro', 'DHL-051', 66966),
(52, 'Mercedes-Benz', 'Crafter', 'DHL-052', 253413),
(53, 'Mercedes-Benz', 'Crafter', 'DHL-053', 96165),
(54, 'Opel', 'Vivaro', 'DHL-054', 30585),
(55, 'Mercedes-Benz', 'Citan', 'DHL-055', 174432),
(56, 'Opel', 'Vivaro', 'DHL-056', 130402),
(57, 'Opel', 'Vivaro', 'DHL-057', 118716),
(58, 'Mercedes-Benz', 'Citan', 'DHL-058', 192375),
(59, 'Opel', 'Vivaro', 'DHL-059', 275726),
(60, 'Mercedes-Benz', 'Crafter', 'DHL-060', 151504),
(61, 'Opel', 'Vivaro', 'DHL-061', 240341),
(62, 'Mercedes-Benz', 'Crafter', 'DHL-062', 97194),
(63, 'Mercedes-Benz', 'Crafter', 'DHL-063', 74946),
(64, 'Opel', 'Vivaro', 'DHL-064', 73149),
(65, 'Mercedes-Benz', 'Citan', 'DHL-065', 130909),
(66, 'Opel', 'Vivaro', 'DHL-066', 105098),
(67, 'Opel', 'Vivaro', 'DHL-067', 122763),
(68, 'Mercedes-Benz', 'Citan', 'DHL-068', 288520),
(69, 'Opel', 'Vivaro', 'DHL-069', 104310),
(70, 'Mercedes-Benz', 'Crafter', 'DHL-070', 285994),
(71, 'Opel', 'Vivaro', 'DHL-071', 147034),
(72, 'Mercedes-Benz', 'Crafter', 'DHL-072', 187192),
(73, 'Mercedes-Benz', 'Crafter', 'DHL-073', 164859),
(74, 'Opel', 'Vivaro', 'DHL-074', 252717),
(75, 'Mercedes-Benz', 'Citan', 'DHL-075', 119006),
(76, 'Opel', 'Vivaro', 'DHL-076', 146883),
(77, 'Opel', 'Vivaro', 'DHL-077', 47397),
(78, 'Mercedes-Benz', 'Citan', 'DHL-078', 106338),
(79, 'Opel', 'Vivaro', 'DHL-079', 59496),
(80, 'Mercedes-Benz', 'Crafter', 'DHL-080', 288467),
(81, 'Opel', 'Vivaro', 'DHL-081', 293847),
(82, 'Mercedes-Benz', 'Crafter', 'DHL-082', 273832),
(83, 'Mercedes-Benz', 'Crafter', 'DHL-083', 157617),
(84, 'Opel', 'Vivaro', 'DHL-084', 276592),
(85, 'Mercedes-Benz', 'Citan', 'DHL-085', 260108),
(86, 'Opel', 'Vivaro', 'DHL-086', 140762),
(87, 'Opel', 'Vivaro', 'DHL-087', 233488),
(88, 'Mercedes-Benz', 'Citan', 'DHL-088', 95151),
(89, 'Opel', 'Vivaro', 'DHL-089', 85294),
(90, 'Mercedes-Benz', 'Crafter', 'DHL-090', 131017),
(91, 'Opel', 'Vivaro', 'DHL-091', 69204),
(92, 'Mercedes-Benz', 'Crafter', 'DHL-092', 262969),
(93, 'Mercedes-Benz', 'Crafter', 'DHL-093', 137230),
(94, 'Opel', 'Vivaro', 'DHL-094', 207246),
(95, 'Mercedes-Benz', 'Citan', 'DHL-095', 294537),
(96, 'Opel', 'Vivaro', 'DHL-096', 200947),
(97, 'Opel', 'Vivaro', 'DHL-097', 111124),
(98, 'Mercedes-Benz', 'Citan', 'DHL-098', 262782),
(99, 'Opel', 'Vivaro', 'DHL-099', 10533),
(100, 'Tesla', 'Model Y', 'DHL-100', 3453);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `employees`
--

CREATE TABLE `employees` (
  `employeeid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `position` varchar(50) NOT NULL,
  `tourid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `employees`
--

INSERT INTO `employees` (`employeeid`, `name`, `position`, `tourid`) VALUES
(1, 'Molnár Balázs Máté', 'CEO', 1),
(2, 'Emily Johnson', 'driver', 2),
(3, 'Michael Williams', 'driver', 3),
(4, 'Jessica Brown', 'driver', 4),
(5, 'David Jones', 'driver', 5),
(6, 'Sarah Miller', 'driver', 6),
(7, 'James Davis', 'driver', 7),
(8, 'Amanda Garcia', 'driver', 8),
(9, 'Robert Martinez', 'driver', 9),
(10, 'Jennifer Anderson', 'driver', 10),
(11, 'William Taylor', 'driver', 11),
(12, 'Elizabeth Thomas', 'driver', 12),
(13, 'Joseph Jackson', 'driver', 13),
(14, 'Patricia White', 'driver', 14),
(15, 'Charles Harris', 'driver', 15),
(16, 'Linda Martin', 'driver', 16),
(17, 'Thomas Thompson', 'driver', 17),
(18, 'Barbara Garcia', 'driver', 18),
(19, 'Christopher Martinez', 'driver', 19),
(20, 'Mary Robinson', 'driver', 20),
(21, 'Oliver Brown', 'driver', 21),
(22, 'Emma Davis', 'driver', 22),
(23, 'Liam Wilson', 'driver', 23),
(24, 'Sophia Moore', 'driver', 24),
(25, 'Mason Taylor', 'driver', 25),
(26, 'Isabella Anderson', 'driver', 26),
(27, 'Logan Thomas', 'driver', 27),
(28, 'Ava Jackson', 'driver', 28),
(29, 'Lucas White', 'driver', 29),
(30, 'Mia Harris', 'driver', 30),
(31, 'Ethan Martin', 'driver', 31),
(32, 'Amelia Thompson', 'driver', 32),
(33, 'Henry Martinez', 'driver', 33),
(34, 'Evelyn Garcia', 'driver', 34),
(35, 'Alexander Martinez', 'driver', 35),
(36, 'Harper Robinson', 'driver', 36),
(37, 'Sebastian Clark', 'driver', 37),
(38, 'Ella Rodriguez', 'driver', 38),
(39, 'Jack Lewis', 'driver', 39),
(40, 'Scarlett Lee', 'driver', 40),
(41, 'Benjamin Walker', 'driver', 41),
(42, 'Charlotte Hall', 'driver', 42),
(43, 'Daniel Allen', 'driver', 43),
(44, 'Avery Young', 'driver', 44),
(45, 'Matthew Hernandez', 'driver', 45),
(46, 'Abigail King', 'driver', 46),
(47, 'Anthony Wright', 'driver', 47),
(48, 'Lily Scott', 'driver', 48),
(49, 'Joshua Green', 'driver', 49),
(50, 'Grace Adams', 'driver', 50),
(51, 'Christopher Baker', 'driver', 51),
(52, 'Zoey Gonzalez', 'driver', 52),
(53, 'Andrew Nelson', 'driver', 53),
(54, 'Natalie Carter', 'driver', 54),
(55, 'Joseph Mitchell', 'driver', 55),
(56, 'Hannah Perez', 'driver', 56),
(57, 'David Roberts', 'driver', 57),
(58, 'Lillian Turner', 'driver', 58),
(59, 'Samuel Phillips', 'driver', 59),
(60, 'Layla Campbell', 'driver', 60),
(61, 'Eleanor Collins', 'driver', 61),
(62, 'Isaac Sanchez', 'driver', 62),
(63, 'Mila Morris', 'driver', 63),
(64, 'Gabriel Rogers', 'driver', 64),
(65, 'Nora Cook', 'driver', 65),
(66, 'Henry Bell', 'driver', 66),
(67, 'Aubrey Murphy', 'driver', 67),
(68, 'Sebastian Cooper', 'driver', 68),
(69, 'Victoria Bailey', 'driver', 69),
(70, 'James Ward', 'driver', 70),
(71, 'Aurora Brooks', 'driver', 71),
(72, 'Julian Powell', 'driver', 72),
(73, 'Stella Long', 'driver', 73),
(74, 'Levi Reed', 'driver', 74),
(75, 'Zoe Howard', 'driver', 75),
(76, 'Dylan Wright', 'driver', 76),
(77, 'Hazel Torres', 'driver', 77),
(78, 'Luke Peterson', 'driver', 78),
(79, 'Penelope Gray', 'driver', 79),
(80, 'Nathan Ramirez', 'driver', 80),
(81, 'Ellie James', 'driver', 81),
(82, 'Caleb Watson', 'driver', 82),
(83, 'Violet Brooks', 'driver', 83),
(84, 'Wyatt Kelly', 'driver', 84),
(85, 'Luna Sanders', 'driver', 85),
(86, 'Jack Price', 'driver', 86),
(87, 'Lucy Bennett', 'driver', 87),
(88, 'Owen Wood', 'driver', 88),
(89, 'Anna Barnes', 'driver', 89),
(90, 'Theodore Ross', 'driver', 90),
(91, 'Addison Henderson', 'driver', 91),
(92, 'Eli Coleman', 'driver', 92),
(93, 'Savannah Jenkins', 'driver', 93),
(94, 'Christian Perry', 'driver', 94),
(95, 'Leah Stewart', 'driver', 95),
(96, 'Elias Foster', 'driver', 96),
(97, 'Paisley Gonzales', 'driver', 97),
(98, 'Asher Bryant', 'driver', 98),
(99, 'Aria Russell', 'driver', 99),
(100, 'Hudson Griffin', 'driver', 100);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `selectedcars`
--

CREATE TABLE `selectedcars` (
  `id` int(11) NOT NULL,
  `driverid` int(11) NOT NULL,
  `carid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `selectedcars`
--

INSERT INTO `selectedcars` (`id`, `driverid`, `carid`) VALUES
(1, 1, 100),
(2, 23, 75),
(3, 28, 8),
(4, 85, 55),
(5, 96, 89),
(6, 52, 30),
(7, 92, 92),
(8, 86, 98),
(9, 84, 36),
(10, 90, 7),
(11, 45, 45),
(12, 46, 69),
(13, 75, 90),
(14, 89, 1),
(15, 44, 19),
(16, 55, 11),
(17, 56, 16),
(18, 94, 80),
(19, 95, 94),
(20, 98, 5),
(21, 88, 10),
(22, 92, 47),
(23, 65, 59),
(24, 64, 72),
(25, 61, 66);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `permission` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `permission`) VALUES
(1, 'user', 'user', 'user'),
(2, 'admin', 'admin', 'admin');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`carid`);

--
-- A tábla indexei `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employeeid`);

--
-- A tábla indexei `selectedcars`
--
ALTER TABLE `selectedcars`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `cars`
--
ALTER TABLE `cars`
  MODIFY `carid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT a táblához `employees`
--
ALTER TABLE `employees`
  MODIFY `employeeid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT a táblához `selectedcars`
--
ALTER TABLE `selectedcars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
