-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gostitelj: 127.0.0.1
-- Čas nastanka: 01. nov 2018 ob 15.17
-- Različica strežnika: 10.1.35-MariaDB
-- Različica PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Zbirka podatkov: `hexapath_hexapath_database_no1`
--

-- --------------------------------------------------------

--
-- Struktura tabele `friend_system`
--

CREATE TABLE `friend_system` (
  `id` int(11) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `user1_id` int(11) NOT NULL,
  `user2_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Odloži podatke za tabelo `friend_system`
--

INSERT INTO `friend_system` (`id`, `time`, `user1_id`, `user2_id`) VALUES
(1, '2018-10-31 11:29:37', 1, 10);

-- --------------------------------------------------------

--
-- Struktura tabele `messages_private`
--

CREATE TABLE `messages_private` (
  `id` int(11) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `text` varchar(1024) NOT NULL,
  `sender_id` int(11) NOT NULL,
  `reciever_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Odloži podatke za tabelo `messages_private`
--

INSERT INTO `messages_private` (`id`, `timestamp`, `text`, `sender_id`, `reciever_id`) VALUES
(1, '2018-10-31 11:25:27', 'BLABLABLABLA', 1, 10),
(2, '2018-10-31 11:25:27', 'albalblablablab', 10, 1),
(3, '2018-10-31 19:09:17', '', 11, 1);

-- --------------------------------------------------------

--
-- Struktura tabele `messages_public`
--

CREATE TABLE `messages_public` (
  `id` int(11) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `text` varchar(1024) NOT NULL,
  `sender_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Struktura tabele `override`
--

CREATE TABLE `override` (
  `id` int(11) NOT NULL,
  `name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Odloži podatke za tabelo `override`
--

INSERT INTO `override` (`id`, `name`) VALUES
(1, 'ONLINE'),
(2, 'INNACTIVE'),
(3, 'OFFLINE');

-- --------------------------------------------------------

--
-- Struktura tabele `participants`
--

CREATE TABLE `participants` (
  `id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Struktura tabele `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `info` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Struktura tabele `rooms`
--

CREATE TABLE `rooms` (
  `id` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `password` varchar(64) NOT NULL,
  `chadmin_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Struktura tabele `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(32) NOT NULL,
  `password` varchar(128) NOT NULL,
  `role_id` int(11) NOT NULL,
  `timestamp` varchar(21) NOT NULL,
  `override_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Odloži podatke za tabelo `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role_id`, `timestamp`, `override_id`) VALUES
(1, 'Ime', '574F4A737CAEDD7BD516AF24DF12A074A334047BF58B2D79C587F162253213CCF152A2A1F3E33997D66FA4369F25E757D6C2FEC7E12BD1D1F651B3B1CCD777C8', 0, '1. 11. 2018 14:59:53', 2),
(10, 'Test', '038AA18AFCA0A680AEF647FAC188DE250AB7CD0DFC5DBC0524565EFABB6ECAD6884D060FB7F9AEBA6547999B598F4D2B0F4542EA23C77511A09F75297D7B5431', 0, '31. 10. 2018 20:07:09', 1),
(11, 'Nemors', '2C7176A77EB35AE29DD823CB389424E2B8F31D0BE7E3D63DCBB95965959085E6E9D6D1B4B735AA6C4208D2B2C3270750B143786DD4EA265462964B026AFE9031', 0, '31. 10. 2018 20:18:37', 1);

--
-- Indeksi zavrženih tabel
--

--
-- Indeksi tabele `friend_system`
--
ALTER TABLE `friend_system`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `messages_private`
--
ALTER TABLE `messages_private`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `messages_public`
--
ALTER TABLE `messages_public`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `override`
--
ALTER TABLE `override`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `participants`
--
ALTER TABLE `participants`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`id`);

--
-- Indeksi tabele `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT zavrženih tabel
--

--
-- AUTO_INCREMENT tabele `friend_system`
--
ALTER TABLE `friend_system`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT tabele `messages_private`
--
ALTER TABLE `messages_private`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT tabele `messages_public`
--
ALTER TABLE `messages_public`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT tabele `override`
--
ALTER TABLE `override`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT tabele `participants`
--
ALTER TABLE `participants`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT tabele `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT tabele `rooms`
--
ALTER TABLE `rooms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT tabele `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
