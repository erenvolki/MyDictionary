using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TAnahtar, TDeger>
    {
        TAnahtar[] _anahtar;
        TDeger[] _deger;

        TAnahtar[] geciciAnahtar;
        TDeger[] geciciDeger;

        public MyDictionary()
        {
            _anahtar = new TAnahtar[0];
            _deger = new TDeger[0];
        }

        public void Add(TAnahtar kelime1, TDeger kelime2)
        {
            geciciAnahtar = _anahtar;
            geciciDeger = _deger;

            _anahtar = new TAnahtar[_anahtar.Length + 1];
            _deger = new TDeger[_deger.Length + 1];

            for (int i = 0; i < geciciAnahtar.Length; i++)
            {
                _anahtar[i] = geciciAnahtar[i];
            }

            for (int i = 0; i < geciciDeger.Length; i++)
            {
                _deger[i] = geciciDeger[i];
            }

            _anahtar[_anahtar.Length - 1] = kelime1;
            _deger[_deger.Length - 1] = kelime2;
        }

        public TAnahtar[] anahtar
        {
            get { return _anahtar; }
        }

        public TDeger[] deger
        {
            get { return _deger; }
        }


    }
}
