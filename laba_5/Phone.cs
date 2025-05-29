﻿using System;

namespace laba_5
{
    public interface IPhone
    {
        string Model { get; set; }
        string Diagonal { get; set; }
        int Cores { get; set; }
        string Platform { get; set; }
        int SimQuantity { get; set; }
        bool HasAI { get; set; }
        bool HasTypeC { get; set; }

        string Has4Cores();
    }

    public class Phone : IPhone
    {
        public string Model { get; set; }
        public string Diagonal { get; set; }
        public int Cores { get; set; }
        public string Platform { get; set; }
        public int SimQuantity { get; set; }
        public bool HasAI { get; set; }
        public bool HasTypeC { get; set; }

        public Phone() { }

        public Phone(string model, string diagonal, int cores, string platform, int simQuantity, bool hasAI, bool hasTypeC)
        {
            Model = model;
            Diagonal = diagonal;
            Cores = cores;
            Platform = platform;
            SimQuantity = simQuantity;
            HasAI = hasAI;
            HasTypeC = hasTypeC;
        }

        public string Has4Cores()
        {
            return Cores == 4 ? "Телефон має 4 ядра" : "Телефон не має 4 ядер";
        }

        public string GetPhone4Cores => Has4Cores();
    }
}
