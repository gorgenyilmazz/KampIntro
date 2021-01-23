using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Inheritance tuzelmusteri bir musteridir demek bu
    //Musterinin icinde olan ozellikler tuzelmusteride de var
    class Corporate:Customer 
    {

       
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
