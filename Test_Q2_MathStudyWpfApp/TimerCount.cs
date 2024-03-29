﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media; 

namespace Test_Q2_MathStudyWpfApp
{
    public class TimerCount : INotifyPropertyChanged
    {
        private Brush winColor;
        public Brush WinColor
        {
            get
            {
                return this.winColor;
            }
            set
            {
                this.winColor = value;
                OnPropertyChanged("WinColor");
            }
        }
        private string result;
        public string Result
        {
            get
            {
                return this.result;
            }
            set
            {
                this.result = value;
                OnPropertyChanged("Result");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"Result name {Result}";
        }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
