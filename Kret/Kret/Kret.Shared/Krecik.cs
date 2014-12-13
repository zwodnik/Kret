using System;
using System.Collections.Generic;
using System.Text;




namespace Kret
{
    class Krecik
    {
        private double Height;
        private bool isShow {get; set;}


        public Krecik()
        {
            this.isShow = false;
            this.Height = 0; // TRZEBA WPISAC WYSOKOSC
            
        }


        public void ShowKret()
        {
            isShow = true;
        }

        public void HideKret()
        {
           
        }




    }
}
