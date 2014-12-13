using System;
using System.Collections.Generic;
using System.Text;




namespace Kret
{
    class Krecik
    {
        private double Height;
        private bool isShow {get; set;}
        private int state = 0;

        public Krecik()
        {
            this.isShow = false;
            this.Height = 0; // TRZEBA WPISAC WYSOKOSC
            
        }


        public void ShowKret()
        {
            isShow = true;
            state = 1;
        }

        public void HideKret()
        {
            state = -1;
        }




    }
}
