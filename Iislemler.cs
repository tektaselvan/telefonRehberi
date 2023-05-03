using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public interface Iislemler
    {
        public void Kaydet();
        public void Sil();
        public void Guncelle();
        public void Listele();
        public void Ara();
    }
}