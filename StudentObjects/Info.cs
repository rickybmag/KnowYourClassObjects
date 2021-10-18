using System;
using System.Collections.Generic;
using System.Text;

namespace StudentObjects
{
    class Info
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string FavoriteFood { get; set; }

        public Info(string Name, string Hometown, string FavoriteFood)
        {
            this.Name = Name;
            this.Hometown = Hometown;
            this.FavoriteFood = FavoriteFood;
        }

    }
}
