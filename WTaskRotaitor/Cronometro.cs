using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WTaskRotaitor
{
    public class Cronometro
    {
        Stopwatch _cronometro = new Stopwatch();

        public string getTempo()
        {
            return String.Format("{0:00}:{1:00}:{2:00}", _cronometro.Elapsed.Hours, _cronometro.Elapsed.Minutes, _cronometro.Elapsed.Seconds);
        }

        public void Start()
        {
            _cronometro.Start();

        }
       



        public void Stop()
        {
            _cronometro.Stop();
        }

        public void Continuar()
        {
            _cronometro.Restart();
        }

        public bool estaParado()
        {
            return _cronometro.IsRunning;
        }


    }
}
