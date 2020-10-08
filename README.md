# Best Restaurants

#### Best Restaurants allows a user to input cuisine types, favorite restaurants and add reviews to those restaurants. Created On: 10/08/2020, Updated Last: 10/08/2020

#### By Janet Karpenske, Jeff Dinsmore, Michael Watts & Ben Stoller

## Description

Best Restaurants is a C#/CSHTML Website that allows you to review your favorite restaurant along with defining their cuisine style. Go ahead submit those 5-star reviews! 

## Setup/Installation Requirements

## MySQL Workbench Schema Setup:
1. Open [MySql Workbench](https://www.mysql.com/products/workbench/) and connect to Local instance
2. Create a new sql tab by clicking the upper left icon: 'Create A New SQL Tab for Executing Queries'
3. Copy and paste the following code into "Query" and "Run":
---
### **Copy The Following Text**
CREATE DATABASE `best_rest` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE best_rest;
CREATE TABLE `categories` (
  `CategoryId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `restaurants` (
  `RestaurantId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `CategoryId` int DEFAULT '0',
  PRIMARY KEY (`RestaurantId`),
  KEY `CategoryId_idx` (`CategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `reviews` (
  `ReviewId` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Content` longtext,
  `RestaurantId` int DEFAULT '0',
  `Stars` int DEFAULT NULL,
  PRIMARY KEY (`ReviewId`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


## Website Setup:
* Download or Clone project from Github repository.
* Open a terminal within BestRest folder within main project directory.
* Use command: 'dotnet restore' to install.
* After installation, type in 'dotnet build'.
* After build, run the program with 'dotnet run' in the terminal.
* If you don't have it already, create a "appsettings.json" file in the "BestRest" directory and Insert the code below with your user name and password for MySQL: 

> {
>  "ConnectionStrings": {
>      "DefaultConnection": "Server=localhost;Port=3306;database=best_rest;uid={YOUR USERNAME};pwd={YOUR USERNAME}"
>  }
>}

* Follow terminal prompts to see application run.

## Known Bugs

No Known Bugs

## Support and contact details

https://github.com/janetkarpenske

## Technologies Used

C#, LINQ, Entity Framework Core, MVCTest, MySql, CSHTML, CSS, Bootstrap and Markdown.

## Link To Active Site:
Not Applicable

### License

This software is licensed under the MIT license.

Copyright (c) 2016 **Janet Karpenske, Jeff Dinsmore, Michael Watts & Ben Stoller** - _Best Restaurants_