﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Araba Markası Eklendi";
        public static string BrandDeleted = "Araba Markası Silindi";
        public static string BrandUpdated = "Araba Markası Güncellendi";
        public static string BrandAddedInvalid = "Marka İsminin Uzunluğunu 2 Karakterden Fazla Olmalı!";
        public static string BrandListed = "Araba Markaları Listelendi";


        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarAddedInvalid = "Araba eklemenemedi";
        public static string CarListed = "Arabalar Listelendi";


        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk  Güncellendi";
        public static string ColorListed = "Araba Renklerı Listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler Listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";

        public static string RentalAdded = "Araba Kiralama işlemi gerçekleşti";
        public static string RentalDeleted = "Araba Kiralama işlemi iptal edildi";
        public static string RentalUpdated = "Araba Kiralama işlemi güncellendi";
        public static string FailedRentalAdd = "Bu araba henüz teslim edilmediği için kiralayamazsınız!";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi";
        public static string RentalListed = "Kiralanan Araçlar Listelendi";
        public static string MaintenanceTime = "Bakım zamanı";

        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token başarıyla oluşturuldu";
        public static string UserRegistered = "Kullanıcı kayıt edildi";
        public static string CarImageCountExceeded = "Araba resim sayısı limiti aşıldı";
    }
}
