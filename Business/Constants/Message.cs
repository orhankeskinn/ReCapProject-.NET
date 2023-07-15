using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {
        public static string CarInvalidDailyPrice = "Car Daily Price is invalid.";
        public static string MaintenanceTime = "System is at maintenance, come back later!";
        public static string CarAdded = "Car added succesfully!";
        public static string CarDeleted = "Car deleted succesfully!";
        public static string CarUpdated = "Car updated succesfully!";

        public static string BrandAdded = "Brand added succesfully!";
        public static string ColorAdded = "Color added succesfully!";
        public static string CarInvalidName = "Car name is invalid.";
        public static string BrandInvalidName = "Brand name is invalid.";
        public static string ColorInvalidName = "Color name is invalid.";
        public static string CarListed = "Cars are listed as desired.";
        public static string BrandListed = "Brands are listed as desired.";
        public static string ColorListed = "Colors are listed as desired.";
        public static string RentalInvalid = "Rental invalid";

        // ************* CAR MESSAGES **************//
        public static string AddedCar = "Araba eklendi.";
        public static string UpdatedCar = "Araba güncellendi.";
        public static string DeletedCar = "Araba silindi.";
        public static string CarNameInValid = "Araba adı en az iki karakterden oluşmalı";
        public static string CarPriceIsNegative = "Araba günlük fiyatı 0'dan büyük olmalıdır";

        // ************* BRAND MESSAGES **************//
        public static string AddedBrand = "Marka eklendi.";
        public static string UpdatedBrand = "Marka güncellendi.";
        public static string DeletedBrand = "Marka silindi.";
        public static string BrandNameInValid = "Marka adı en az iki karakterden oluşmalı";

        // ************* COLOR MESSAGES **************//
        public static string AddedColor = "Renk eklendi.";
        public static string UpdatedColor = "Renk güncellendi.";
        public static string DeletedColor = "Renk silindi.";
        public static string ColorNameInValid = "Renk adı en az iki karakterden oluşmalı";

        // ************* RENTAL MESSAGES **************//
        public static string CarNotReturn = "İstediğiniz araç henüz teslim edilmemiş";

    }
}
