using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // Interface ile bir şablonda birden fazla iş yapabiliriz.(Hesaplama,Silme vb gibi)
    interface IKrediManager
    {
       void Hesapla();
       void BiseyYap();
    }
}
