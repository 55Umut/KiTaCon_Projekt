-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 07. Aug 2025 um 10:35
-- Server-Version: 10.4.27-MariaDB
-- PHP-Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `kitacon`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `abholungen`
--

CREATE TABLE `abholungen` (
  `id` int(11) NOT NULL,
  `kind_id` int(11) DEFAULT NULL,
  `abholer` varchar(100) NOT NULL,
  `zeit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `abholungen`
--

INSERT INTO `abholungen` (`id`, `kind_id`, `abholer`, `zeit`) VALUES
(1, 1, 'Maria Müller', '2025-05-19 16:00:00'),
(2, 2, 'Peter Schmidt', '2025-05-19 16:30:00');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `aktivitaeten`
--

CREATE TABLE `aktivitaeten` (
  `id` int(11) NOT NULL,
  `kind_id` int(11) DEFAULT NULL,
  `beschreibung` text NOT NULL,
  `zeit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `aktivitaeten`
--

INSERT INTO `aktivitaeten` (`id`, `kind_id`, `beschreibung`, `zeit`) VALUES
(1, 1, 'Bastelstunde', '2025-05-19 10:00:00'),
(2, 2, 'Spielplatzbesuch', '2025-05-19 11:00:00');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `dienstplaene`
--

CREATE TABLE `dienstplaene` (
  `id` int(11) NOT NULL,
  `erzieher_id` int(11) DEFAULT NULL,
  `kita_id` int(11) DEFAULT NULL,
  `datum` datetime NOT NULL,
  `schicht` enum('Frühschicht','Spätschicht') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `dienstplaene`
--

INSERT INTO `dienstplaene` (`id`, `erzieher_id`, `kita_id`, `datum`, `schicht`) VALUES
(1, 1, 1, '2025-05-19 08:00:00', 'Frühschicht'),
(2, 3, 2, '2025-05-19 12:00:00', 'Spätschicht');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `entwicklungsberichte`
--

CREATE TABLE `entwicklungsberichte` (
  `id` int(11) NOT NULL,
  `kind_id` int(11) DEFAULT NULL,
  `bericht` text NOT NULL,
  `datum` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `entwicklungsberichte`
--

INSERT INTO `entwicklungsberichte` (`id`, `kind_id`, `bericht`, `datum`) VALUES
(1, 1, 'Anna zeigt Fortschritte im Malen.', '2025-05-19 12:00:00'),
(2, 2, 'Ben ist sehr aktiv im Sport.', '2025-05-19 12:00:00');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ereignisse`
--

CREATE TABLE `ereignisse` (
  `id` int(11) NOT NULL,
  `titel` varchar(100) NOT NULL,
  `datum` datetime NOT NULL,
  `beschreibung` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `ereignisse`
--

INSERT INTO `ereignisse` (`id`, `titel`, `datum`, `beschreibung`) VALUES
(1, 'Elternabend', '2025-05-20 18:00:00', 'Besprechung der kommenden Projekte'),
(2, 'Kita-Fest', '2025-06-01 14:00:00', 'Sommerfest mit Spielen');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `essensplaene`
--

CREATE TABLE `essensplaene` (
  `id` int(11) NOT NULL,
  `kita_id` int(11) DEFAULT NULL,
  `datum` datetime NOT NULL,
  `speise` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `essensplaene`
--

INSERT INTO `essensplaene` (`id`, `kita_id`, `datum`, `speise`) VALUES
(1, 1, '2025-05-19 12:00:00', 'Spaghetti Bolognese'),
(2, 2, '2025-05-19 12:00:00', 'Gemüsesuppe');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `facilities`
--

CREATE TABLE `facilities` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `type` enum('Kita','Schule','Jugendzentrum','Weiterbildungsraum','Lernraum') NOT NULL,
  `address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fotos`
--

CREATE TABLE `fotos` (
  `id` int(11) NOT NULL,
  `kind_id` int(11) DEFAULT NULL,
  `dateipfad` varchar(255) NOT NULL,
  `datum` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `fotos`
--

INSERT INTO `fotos` (`id`, `kind_id`, `dateipfad`, `datum`) VALUES
(1, 1, 'C:/fotos/anna_basteln.jpg', '2025-05-19 10:00:00'),
(2, 2, 'C:/fotos/ben_spielplatz.jpg', '2025-05-19 11:00:00');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kinder`
--

CREATE TABLE `kinder` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `eltern_id` int(11) DEFAULT NULL,
  `kita_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kinder`
--

INSERT INTO `kinder` (`id`, `name`, `eltern_id`, `kita_id`) VALUES
(1, 'Anna Müller', 2, 1),
(2, 'Ben Schmidt', 2, 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kitas`
--

CREATE TABLE `kitas` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `adresse` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kitas`
--

INSERT INTO `kitas` (`id`, `name`, `adresse`) VALUES
(1, 'Sonnenschein Kita', 'Musterstraße 1, 12345 Musterstadt'),
(2, 'Regenbogen Kita', 'Beispielweg 2, 67890 Beispielstadt');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `nachrichten`
--

CREATE TABLE `nachrichten` (
  `id` int(11) NOT NULL,
  `absender_id` int(11) DEFAULT NULL,
  `empfanger_id` int(11) DEFAULT NULL,
  `nachricht` text NOT NULL,
  `zeit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `nachrichten`
--

INSERT INTO `nachrichten` (`id`, `absender_id`, `empfanger_id`, `nachricht`, `zeit`) VALUES
(1, 1, 2, 'Bitte Abholzeit für Anna bestätigen.', '2025-05-19 09:00:00'),
(2, 2, 1, 'Anna wird um 16:00 abgeholt.', '2025-05-19 09:30:00');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `benutzername` varchar(50) NOT NULL,
  `passwort` varchar(255) NOT NULL,
  `rolle` enum('Erzieher','Eltern') NOT NULL,
  `kita_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `users`
--

INSERT INTO `users` (`id`, `benutzername`, `passwort`, `rolle`, `kita_id`) VALUES
(0, 'zzzz', '$2a$10$eaM9NVxIf8wc3QUZmydEjOU7PWsaC8qXb.sklbS5n8MwjnhgUEksG', 'Eltern', 2),
(1, 'Erzieher1', '$2a$11$zYx8z3k1zYx8z3k1zYx8zu1zYx8z3k1zYx8z3k1zYx8', 'Erzieher', 1),
(2, 'Eltern1', '$2a$11$zYx8z3k1zYx8z3k1zYx8zu1zYx8z3k1zYx8z3k1zYx8', 'Eltern', 1),
(3, 'Erzieher2', '$2a$11$zYx8z3k1zYx8z3k1zYx8zu1zYx8z3k1zYx8z3k1zYx8', 'Erzieher', 2),
(4, 'Eltern3', '$2a$10$l205jD6BREqmgpTOic80Nea/JGzGOMKEiwXquxtMyYg', 'Eltern', 1),
(5, 'Erzieher3', '$2a$10$cgToC6OhUsVQFk0RYTUHiOMB50E7zvqh87qQOmq5MmV', 'Erzieher', 1),
(6, 'Elmar', '$2a$10$aNdak06WyvqPhQYWK9cDyuAXvg42RLe16W9ZvLxJCzs', 'Eltern', 1),
(7, 'babo', '$2a$10$wVOLI.qJ1KA6/P9fTVz/jO3VbjIr.zPaS8r7Zl7sA8a', 'Erzieher', 2);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `abholungen`
--
ALTER TABLE `abholungen`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kind_id` (`kind_id`);

--
-- Indizes für die Tabelle `aktivitaeten`
--
ALTER TABLE `aktivitaeten`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kind_id` (`kind_id`);

--
-- Indizes für die Tabelle `dienstplaene`
--
ALTER TABLE `dienstplaene`
  ADD PRIMARY KEY (`id`),
  ADD KEY `erzieher_id` (`erzieher_id`),
  ADD KEY `kita_id` (`kita_id`);

--
-- Indizes für die Tabelle `entwicklungsberichte`
--
ALTER TABLE `entwicklungsberichte`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kind_id` (`kind_id`);

--
-- Indizes für die Tabelle `ereignisse`
--
ALTER TABLE `ereignisse`
  ADD PRIMARY KEY (`id`);

--
-- Indizes für die Tabelle `essensplaene`
--
ALTER TABLE `essensplaene`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kita_id` (`kita_id`);

--
-- Indizes für die Tabelle `facilities`
--
ALTER TABLE `facilities`
  ADD PRIMARY KEY (`id`);

--
-- Indizes für die Tabelle `fotos`
--
ALTER TABLE `fotos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kind_id` (`kind_id`);

--
-- Indizes für die Tabelle `kinder`
--
ALTER TABLE `kinder`
  ADD PRIMARY KEY (`id`),
  ADD KEY `eltern_id` (`eltern_id`),
  ADD KEY `kita_id` (`kita_id`);

--
-- Indizes für die Tabelle `kitas`
--
ALTER TABLE `kitas`
  ADD PRIMARY KEY (`id`);

--
-- Indizes für die Tabelle `nachrichten`
--
ALTER TABLE `nachrichten`
  ADD PRIMARY KEY (`id`),
  ADD KEY `absender_id` (`absender_id`),
  ADD KEY `empfanger_id` (`empfanger_id`);

--
-- Indizes für die Tabelle `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `facilities`
--
ALTER TABLE `facilities`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `abholungen`
--
ALTER TABLE `abholungen`
  ADD CONSTRAINT `abholungen_ibfk_1` FOREIGN KEY (`kind_id`) REFERENCES `kinder` (`id`);

--
-- Constraints der Tabelle `aktivitaeten`
--
ALTER TABLE `aktivitaeten`
  ADD CONSTRAINT `aktivitaeten_ibfk_1` FOREIGN KEY (`kind_id`) REFERENCES `kinder` (`id`);

--
-- Constraints der Tabelle `dienstplaene`
--
ALTER TABLE `dienstplaene`
  ADD CONSTRAINT `dienstplaene_ibfk_1` FOREIGN KEY (`erzieher_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `dienstplaene_ibfk_2` FOREIGN KEY (`kita_id`) REFERENCES `kitas` (`id`);

--
-- Constraints der Tabelle `entwicklungsberichte`
--
ALTER TABLE `entwicklungsberichte`
  ADD CONSTRAINT `entwicklungsberichte_ibfk_1` FOREIGN KEY (`kind_id`) REFERENCES `kinder` (`id`);

--
-- Constraints der Tabelle `essensplaene`
--
ALTER TABLE `essensplaene`
  ADD CONSTRAINT `essensplaene_ibfk_1` FOREIGN KEY (`kita_id`) REFERENCES `kitas` (`id`);

--
-- Constraints der Tabelle `fotos`
--
ALTER TABLE `fotos`
  ADD CONSTRAINT `fotos_ibfk_1` FOREIGN KEY (`kind_id`) REFERENCES `kinder` (`id`);

--
-- Constraints der Tabelle `kinder`
--
ALTER TABLE `kinder`
  ADD CONSTRAINT `kinder_ibfk_1` FOREIGN KEY (`eltern_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `kinder_ibfk_2` FOREIGN KEY (`kita_id`) REFERENCES `kitas` (`id`);

--
-- Constraints der Tabelle `nachrichten`
--
ALTER TABLE `nachrichten`
  ADD CONSTRAINT `nachrichten_ibfk_1` FOREIGN KEY (`absender_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `nachrichten_ibfk_2` FOREIGN KEY (`empfanger_id`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
