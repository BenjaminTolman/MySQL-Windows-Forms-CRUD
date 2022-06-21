/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE IF NOT EXISTS `contactlist` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `contactlist`;

CREATE TABLE IF NOT EXISTS `mycontacts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `PhoneNumber` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Relation` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;

/*!40000 ALTER TABLE `mycontacts` DISABLE KEYS */;
REPLACE INTO `mycontacts` (`id`, `FirstName`, `LastName`, `PhoneNumber`, `Email`, `Relation`) VALUES
	(2, 'Jon', 'Tilly', '2533598888', 'jt@super.net', 'friend'),
	(3, 'Jill', 'Roboson', '2533699955', 'Jilly27@hotmail.com', 'other'),
	(4, 'Bobby', 'Newtron', '2274864414', 'thenewt@gmail.com', 'business'),
	(5, 'Jackie', 'Tormand', '6032566585', 'wackyjackie@cool.edu', 'family'),
	(6, 'brad', 'nanigans', '2544565654', 'bradnan@zimbo.com', 'friend'),
	(7, 'Bobbyst', 'Grant', '2223332345', 'bgran@hotmail.edu', 'other'),
	(9, 'Jimsanthins', 'Jogglesworth', '2223332345', 'jjoggs@jj.net', 'business'),
	(10, 'Trester', 'Tester', '1234567891', 'sdfsdf@t.com', 'business'),
	(22, 'Greg', 'Tyson', '6033592083', 'greg@stampy.net', 'business'),
	(23, 'Sampson', 'Swanson', '6674356765', 'sswanson337@gmail.com', 'friend');
/*!40000 ALTER TABLE `mycontacts` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
