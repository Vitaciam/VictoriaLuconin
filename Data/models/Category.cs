﻿namespace VictoriaLuconin.Data.models
{
    public class Category
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string description { set; get; }

        public List<Car> cars  { set; get; }
    }
}
