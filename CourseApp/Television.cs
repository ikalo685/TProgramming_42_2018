﻿using System;

namespace CourseApp
{
    public class Television
    {
        private int channel;
        private int model;
        private int age;
        public int Channel
        {
            get
            {
                return channel;
            }
            set
            {
                if (value <= 0)
                    channel = 0;
                else if (value >= 255)
                    channel = 255;
                else channel = value;
            }
       }
        public int Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value <= 1)
                    model = 1;
                else if (value >= 2) model = 2;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    age = 0;
                else if (value > 15)
                    age = 15;
                else age = value;
            }
        }
        public Television() { Channel = 1; Model = 1; Age = 0; }
        public Television(int ch)
        {
            Channel = ch;
            if (ch < 0) { Console.WriteLine("Канал должен быть >= 0"); }
            else{
                if (ch >= 100)
                {
                    Model = 1; Age = 3;
                }
                else
                {
                    Model = 2; Age = 7;
                }
            } }
        public Television(int ch, int md, byte ag)
        {
            Channel = ch;
            Model = md;
            Age = ag;
        }
        public string GetInfo()
        {
            string h = "";
            for (int i = 0; i < 3 - Channel.ToString().Length; i++) h += (Model == 1) ? "▒" : "░";
                if (Model == 1) return ($"\nКанал: {Channel}, Модель телевизора: {Model}, Возвраст телевизора: {Age}\n ▄██████████████████████████████████████▄\n █▀─▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄─▀████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒Канал {Channel}{h}▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▄─▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀─▄████████\n ▀██████████████████████████████████████▀\n ───▄▄▄████████████████████████████▄▄▄\n ──████████████████████████████████████");
                else return ($"\nКанал: {Channel}, Модель телевизора: {Model}, Возвраст телевизора: {Age}\n ██████████░▀▀██████████████▀▀░██████████\n ████████████▄░▀▀████████▀▀░▄████████████\n ███████████████▄█▀▀▀▀▀▀█▄███████████████\n ████████████████▄▄▄▄▄▄▄▄████████████████\n ████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████\n ███░░▄▄█████████████████████▄░░░▄▄░░░███\n ███░░█▀░Канал {Channel}{h}▄▄▄▄█████████░████░░███\n ███░░█░░░░░░░▄████████████████░░▀▀░░░███\n ███░░█░░░░▄███████████████████░░░░░░░███\n ███░░█░░░█████████████████████░░░░░░░███\n ███░░█░░██████████████████████░░░░░░░███\n ███░░█░███████████████████████░▀███░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░▀███████████████████████▀░░▀▀▀░░███\n ███▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄███\n ████████████████████████████████████████");
        }
    }
}
