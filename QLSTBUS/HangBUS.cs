﻿using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSTBUS
{
    public class HangBUS
    {
        private HangDAL HangDAL;
        public HangBUS()
        {
            this.HangDAL = new HangDAL();
        }

        public bool suaPhieu(HangDTO ts)
        {
            bool re = this.HangDAL.sua(ts);
            return re;
        }

        public bool themPhieu(HangDTO ts)
        {
            bool re = this.HangDAL.them(ts);
            return re;
        }

        public bool xoaPhieu(HangDTO ts)
        {
            bool re = this.HangDAL.xoa(ts);
            return re;
        }
    }
}
