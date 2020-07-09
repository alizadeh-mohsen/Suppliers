using System.Collections.Generic;
using Suppliers.Models;
using SuppliersHub.Models;

namespace Suppliers.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.SuppliersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SuppliersDbContext context)
        {

            var provinces = new List<Province>
            {
            new Province {Name = "آذربايجان شرقي"},
            new Province {Name = "آذربايجان غربي"},
            new Province {Name = "اردبيل"},
            new Province {Name = "اصفهان"},
            new Province {Name = "البرز"},
            new Province {Name = "ايلام"},
            new Province {Name = "بوشهر"},
            new Province {Name = "تهران"},
            new Province {Name = "چهارمحال و بختياري"},
            new Province {Name ="خراسان جنوبي"}

        };

            provinces.ForEach(s => context.Provinces.Add(s));
            context.SaveChanges();

            var cities = new List<City>
            {
                new City {Name = "آذرشهر", ProvinceId = 1},
                new City {Name = "اسكو", ProvinceId = 1},
                new City {Name = "اهر", ProvinceId = 1},
                new City {Name = "بستان آباد", ProvinceId = 1},
                new City {Name = "بناب", ProvinceId = 1},
                new City {Name = "تبريز", ProvinceId = 1},
                new City {Name = "جلفا", ProvinceId = 1},
                new City {Name = "چار اويماق", ProvinceId = 1},
                new City {Name = "سراب", ProvinceId = 1},
                new City {Name = "شبستر", ProvinceId = 1},
                new City {Name = "عجبشير", ProvinceId = 1},
                new City {Name = "كليبر", ProvinceId = 1},
                new City {Name = "مراغه", ProvinceId = 1},
                new City {Name = "مرند", ProvinceId = 1},
                new City {Name = "ملكان", ProvinceId = 1},
                new City {Name = "ميانه", ProvinceId = 1},
                new City {Name = "ورزقان", ProvinceId = 1},
                new City {Name = "هريس", ProvinceId = 1},
                new City {Name = "هشترود", ProvinceId = 1},
                new City {Name = "اروميه", ProvinceId = 2},
                new City {Name = "اشنويه", ProvinceId = 2},
                new City {Name = "بوكان", ProvinceId = 2},
                new City {Name = "پير انشهر", ProvinceId = 2},
                new City {Name = "تكاب", ProvinceId = 2},
                new City {Name = "چالدران", ProvinceId = 2},
                new City {Name = "خوي", ProvinceId = 2},
                new City {Name = "سردشت", ProvinceId = 2},
                new City {Name = "سلماس", ProvinceId = 2},
                new City {Name = "شاهين دژ", ProvinceId = 2},
                new City {Name = "ماكو", ProvinceId = 2},
                new City {Name = "مهاباد", ProvinceId = 2},
                new City {Name = "مياندوآب", ProvinceId = 2},
                new City {Name = "نقده", ProvinceId = 2},
                new City {Name = "اردبيل", ProvinceId = 3},
                new City {Name = "بيله سوار", ProvinceId = 3},
                new City {Name = "پارس آباد", ProvinceId = 3},
                new City {Name = "خلخال", ProvinceId = 3},
                new City {Name = "كوثر", ProvinceId = 3},
                new City {Name = "گرمي", ProvinceId = 3},
                new City {Name = "مشگين", ProvinceId = 3},
                new City {Name = "نمين", ProvinceId = 3},
                new City {Name = "نير", ProvinceId = 3},
                new City {Name = "آران و بيدگل", ProvinceId = 4},
                new City {Name = "اردستان", ProvinceId = 4},
                new City {Name = "اصفهان", ProvinceId = 4},
                new City {Name = "برخوار و ميمه", ProvinceId = 4},
                new City {Name = "تيران و كرون", ProvinceId = 4},
                new City {Name = "چادگان", ProvinceId = 4},
                new City {Name = "خميني شهر", ProvinceId = 4},
                new City {Name = "خوانسار", ProvinceId = 4},
                new City {Name = "سميرم", ProvinceId = 4},
                new City {Name = "شاهين شهر و ميمه", ProvinceId = 4},
                new City {Name = "شهر رضا", ProvinceId = 4},
                new City {Name = "سميرم سفلي", ProvinceId = 4},
                new City {Name = "فريدن", ProvinceId = 4},
                new City {Name = "فريدون شهر", ProvinceId = 4},
                new City {Name = "فلاورجان", ProvinceId = 4},
                new City {Name = "كاشان", ProvinceId = 4},
                new City {Name = "گلپايگان", ProvinceId = 4},
                new City {Name = "لنجان", ProvinceId = 4},
                new City {Name = "مباركه", ProvinceId = 4},
                new City {Name = "نائين", ProvinceId = 4},
                new City {Name = "نجف آباد", ProvinceId = 4},
                new City {Name = "نطنز", ProvinceId = 4},
                new City {Name = "ساوجبلاق", ProvinceId = 5},
                new City {Name = "كرج", ProvinceId = 5},
                new City {Name = "نظرآباد", ProvinceId = 5},
                new City {Name = "طالقان", ProvinceId = 5},
                new City {Name = "آبدانان", ProvinceId = 6},
                new City {Name = "ايلام", ProvinceId = 6},
                new City {Name = "ايوان", ProvinceId = 6},
                new City {Name = "دره شهر", ProvinceId = 6},
                new City {Name = "دهلران", ProvinceId = 6},
                new City {Name = "شيران و چرداول", ProvinceId = 6},
                new City {Name = "مهران", ProvinceId = 6},
                new City {Name = "بوشهر", ProvinceId = 7},
                new City {Name = "تنگستان", ProvinceId = 7},
                new City {Name = "جم", ProvinceId = 7},
                new City {Name = "دشتستان", ProvinceId = 7},
                new City {Name = "دشتي", ProvinceId = 7},
                new City {Name = "دير", ProvinceId = 7},
                new City {Name = "ديلم", ProvinceId = 7},
                new City {Name = "كنگان", ProvinceId = 7},
                new City {Name = "گناوه", ProvinceId = 7},
                new City {Name = "اسلام شهر", ProvinceId = 8},
                new City {Name = "پاكدشت", ProvinceId = 8},
                new City {Name = "تهران", ProvinceId = 8},
                new City {Name = "دماوند", ProvinceId = 8},
                new City {Name = "رباط كريم", ProvinceId = 8},
                new City {Name = "ري", ProvinceId = 8},
                new City {Name = "شميرانات", ProvinceId = 8},
                new City {Name = "شهريار", ProvinceId = 8},
                new City {Name = "فيروزكوه", ProvinceId = 8},
                new City {Name = "ورامين", ProvinceId = 8},
                new City {Name = "اردل", ProvinceId = 9},
                new City {Name = "بروجن", ProvinceId = 9},
                new City {Name = "شهركرد", ProvinceId = 9},
                new City {Name = "فارسان", ProvinceId = 9},
                new City {Name = "كوهرنگ", ProvinceId = 9},
                new City {Name = "لردگان", ProvinceId = 9},
                new City {Name = "بيرجند", ProvinceId = 10},
                new City {Name = "درميان", ProvinceId = 10},
                new City {Name = "سرايان", ProvinceId = 10},
                new City {Name = "سر بيشه", ProvinceId = 10},
                new City {Name = "فردوس", ProvinceId = 10},
                new City {Name = "قائن", ProvinceId = 10},
                new City {Name = "نهبندان", ProvinceId = 10}

            };
            cities.ForEach(s => context.Cities.Add(s));
            context.SaveChanges();

        }
    }
}
