using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ValueConvertersProject
{
    public class ARGB : INotifyPropertyChanged
    {
        private int a = 255;
        private int r = 255;
        private int g = 255;
        private int b = 255;

        public event PropertyChangedEventHandler PropertyChanged;

        public int AValue
        {
            get { return a; }
            set
            {
                if(value>255)
                {
                    value = 255;
                }
                a = value;
                FieldChanged();
            }
        }
        public int RValue
        {
            get { return r; }
            set
            {
                if (value > 255)
                {
                    value = 255;
                }
                r = value;
                FieldChanged();
            }
        }
        public int GValue
        {
            get { return g; }
            set
            {
                if (value > 255)
                {
                    value = 255;
                }
                g = value;
                FieldChanged();
            }
        }
        public int BValue
        {
            get { return b; }
            set
            {
                if (value > 255)
                {
                    value = 255;
                }
                b = value;
                FieldChanged();
            }
        }
        public void FieldChanged([CallerMemberName] string field = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(field));
        }
    }

   
}
