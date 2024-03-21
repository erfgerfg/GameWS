-- MySQL Script generated by MySQL Workbench
-- Thu May  4 10:26:50 2023
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema samk
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema samk
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `samk` DEFAULT CHARACTER SET utf8 ;
USE `samk` ;

-- -----------------------------------------------------
-- Table `samk`.`Настройки звука`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Настройки звука` (
  `idНастройки звука` INT NOT NULL AUTO_INCREMENT,
  `Включен` VARCHAR(45) NOT NULL,
  `Выключен` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idНастройки звука`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Настройки музыки`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Настройки музыки` (
  `idНастройки музыки` INT NOT NULL AUTO_INCREMENT,
  `Включена` VARCHAR(45) NOT NULL,
  `Выключена` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idНастройки музыки`),
  CONSTRAINT `Настройки звука`
    FOREIGN KEY ()
    REFERENCES `samk`.`Настройки звука` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Настройки графики`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Настройки графики` (
  `idНастройки графики` INT NOT NULL AUTO_INCREMENT,
  `Низкая` VARCHAR(45) NOT NULL,
  `Средняя` VARCHAR(45) NOT NULL,
  `Высокая` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idНастройки графики`),
  CONSTRAINT `Настройки музыки`
    FOREIGN KEY ()
    REFERENCES `samk`.`Настройки музыки` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Дата и время последнего входа в игру`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Дата и время последнего входа в игру` (
  `idДата и время последнего входа в игру` INT NOT NULL AUTO_INCREMENT,
  `Дата` DATE NOT NULL,
  `Время` TIME NOT NULL,
  `Год` YEAR(2023) NOT NULL,
  PRIMARY KEY (`idДата и время последнего входа в игру`),
  CONSTRAINT `Настройки графики`
    FOREIGN KEY ()
    REFERENCES `samk`.`Настройки графики` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Дата регистрации`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Дата регистрации` (
  `idДата регистрации` INT NOT NULL AUTO_INCREMENT,
  `Дата` DATE NOT NULL,
  `Время` TIME NOT NULL,
  `Год` YEAR(10) NOT NULL,
  PRIMARY KEY (`idДата регистрации`),
  CONSTRAINT `Дата и время последнего входа в игру`
    FOREIGN KEY ()
    REFERENCES `samk`.`Дата и время последнего входа в игру` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Настройки окружения`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Настройки окружения` (
  `idНастройки окружения` INT NOT NULL AUTO_INCREMENT,
  `Деревья` VARCHAR(45) NOT NULL,
  `Камни` VARCHAR(45) NOT NULL,
  `Кусты` VARCHAR(45) NOT NULL,
  `Озёра` VARCHAR(45) NOT NULL,
  `Грибы` VARCHAR(45) NOT NULL,
  `Мухоморы` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idНастройки окружения`),
  CONSTRAINT `Дата регистрации`
    FOREIGN KEY ()
    REFERENCES `samk`.`Дата регистрации` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Покупка ресурсов`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Покупка ресурсов` (
  `idПокупка ресурсов` INT NOT NULL AUTO_INCREMENT,
  `Монеты` VARCHAR(1000) NOT NULL,
  `Время` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idПокупка ресурсов`),
  CONSTRAINT `Настройки окружения`
    FOREIGN KEY ()
    REFERENCES `samk`.`Настройки окружения` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`ФИО`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`ФИО` (
  `idФИО` INT NOT NULL AUTO_INCREMENT,
  `Фамилия` VARCHAR(45) NOT NULL,
  `Имя` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idФИО`),
  CONSTRAINT `Покупка ресурсов`
    FOREIGN KEY ()
    REFERENCES `samk`.`Покупка ресурсов` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Данные регистрации`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Данные регистрации` (
  `idДанные регистрации` INT NOT NULL AUTO_INCREMENT,
  `E-mail` VARCHAR(45) NOT NULL,
  `Имя` VARCHAR(45) NOT NULL,
  `Пароль` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idДанные регистрации`),
  CONSTRAINT `ФИО`
    FOREIGN KEY ()
    REFERENCES `samk`.`ФИО` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `samk`.`Роли, логины и пароли`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `samk`.`Роли, логины и пароли` (
  `idРоли, логины и пароли` INT NOT NULL AUTO_INCREMENT,
  `Роли` VARCHAR(45) NOT NULL,
  `Логины` VARCHAR(45) NOT NULL,
  `Пароли` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idРоли, логины и пароли`),
  CONSTRAINT `Данные регистрации`
    FOREIGN KEY ()
    REFERENCES `samk`.`Данные регистрации` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
