-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 20, 2019 at 04:25 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpos`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `kode_barang` int(11) NOT NULL,
  `nama_barang` varchar(20) DEFAULT NULL,
  `harga_satuan` int(11) DEFAULT NULL,
  `stok_barang` int(11) DEFAULT NULL,
  `biaya_pesan` int(11) NOT NULL,
  `biaya_simpan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`kode_barang`, `nama_barang`, `harga_satuan`, `stok_barang`, `biaya_pesan`, `biaya_simpan`) VALUES
(1, 'kacang kedelai', 28000, 999, 2800, 560),
(2, 'telur', 25000, 978, 2500, 500),
(3, 'plastik', 4000, 999, 400, 80),
(4, 'pakan ayam', 10000, 998, 1000, 200),
(5, 'pakan ikan ', 5000, 998, 500, 100),
(6, 'beras', 9000, 973, 900, 180),
(7, 'semen', 58000, 1000, 5800, 1160),
(8, 'cream pemutih', 10000, 987, 1000, 200),
(9, 'gula pasir', 13000, 1000, 1300, 260),
(10, 'minyak sayur', 10000, 1000, 1000, 200),
(11, 'minyak tanah', 14000, 1000, 1400, 280),
(12, 'gas elpiji', 23000, 1000, 2300, 460),
(14, 'tepung', 7000, 840, 700, 140);

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `id_pelanggan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`id_pelanggan`) VALUES
('Jx8448Q0'),
('Nd8pUI6X'),
('pOMYgjf1');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id` int(11) NOT NULL,
  `kode_barang` int(11) DEFAULT NULL,
  `id_pelanggan` varchar(20) DEFAULT NULL,
  `banyaknya` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id`, `kode_barang`, `id_pelanggan`, `banyaknya`, `jumlah`, `tanggal`) VALUES
(1, 2, 'Nd8pUI6X', 1, 25000, '2019-08-05'),
(2, 3, 'Nd8pUI6X', 1, 4000, '2019-08-05'),
(3, 4, 'Nd8pUI6X', 1, 10000, '2019-08-05'),
(4, 5, 'Nd8pUI6X', 1, 5000, '2019-08-05'),
(5, 8, 'Nd8pUI6X', 1, 10000, '2019-08-05'),
(6, 2, 'Nd8pUI6X', 20, 500000, '2019-08-05'),
(7, 1, 'pOMYgjf1', 1, 28000, '2019-08-05'),
(8, 2, 'pOMYgjf1', 1, 25000, '2019-08-05'),
(9, 5, 'pOMYgjf1', 1, 5000, '2019-08-05'),
(10, 8, 'pOMYgjf1', 5, 50000, '2019-08-05'),
(11, 6, 'pOMYgjf1', 1, 9000, '2019-08-05'),
(12, 4, 'pOMYgjf1', 1, 10000, '2019-08-05'),
(13, 6, 'pOMYgjf1', 1, 9000, '2019-08-05'),
(14, 8, 'pOMYgjf1', 7, 70000, '2019-08-05'),
(15, 6, 'pOMYgjf1', 25, 225000, '2019-08-05'),
(16, 14, 'Jx8448Q0', 160, 1120000, '2019-08-06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`kode_barang`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK` (`kode_barang`,`id_pelanggan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `kode_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
