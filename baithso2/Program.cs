using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithso2
{
    class PS
    {
        private int ts,ms;
        public PS()
        {
            ts = 0;ms = 1;
        }
        public PS(int ts,int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public PS(PS t2)
        {
            this.ts = t2.ts;
            this.ms = t2.ms;
        }
        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + t2.ms * this.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - t2.ms * this.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Nhan(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS CHIA(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t;
        }
        public bool Ktra(PS t2)
        {
            if (this.ts == t2.ts && this.ms == t2.ms)
                return 0;
       }
       
        


    }
}
