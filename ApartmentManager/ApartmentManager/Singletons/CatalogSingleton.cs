﻿using System;
using System.Collections.ObjectModel;
using ApartmentManager.Model;

namespace ApartmentManager.Singletons
{
    public class CatalogSingleton
    {
        private static CatalogSingleton instance = new CatalogSingleton();

        public static CatalogSingleton Instance => instance;


        public Apartment Apartment { get; set; }
        public ObservableCollection<Resident> Residents { get; set; }
        public ObservableCollection<Defect> Defects { get; set; }
        private CatalogSingleton()
        {
            Residents = new ObservableCollection<Resident>();
            Defects = new ObservableCollection<Defect>();
            Defects.Add(new Defect(1, 1, "Broken Pipe", new DateTime(1988, 8, 8), "description", "status"));
            Defects.Add(new Defect(1, 1, "Broken Pipe", new DateTime(1988, 8, 8), "description", "status"));
            Defects.Add(new Defect(1, 1, "Broken Pipe", new DateTime(1988, 8, 8), "description", "status"));
            Defects.Add(new Defect(1, 1, "Broken Pipe", new DateTime(1988, 8, 8), "description", "status"));
        }
    }
}
