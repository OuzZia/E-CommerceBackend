using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride yer alabilecek maximum ürün sayısı aşıldı";
        public static string ProductNameError = "Aynı isimde birden fazla ürün eklenemez";
        public static string ProductNameAlreadyExists = "Aynı isimde birden fazla ürün eklenemez";
        public static string CategoryLimitExceded = "Maksimum kategori sayısı limiti aşıldığı için yeni ürün eklenemez";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kaydı başarılı";
        public static string UserNotFound = "Kullanıcı kaydı bulunamadı";
        public static string PasswordError = "Şifre hatalı, giriş başarısız";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu emaile ait başka bir kayıt mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string Updated = "Güncellendi";
        public static string InvalidEntity = "Kayıt bulunamadı";
    }
}
