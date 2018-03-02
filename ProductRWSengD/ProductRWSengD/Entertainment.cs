﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWSengD
{
    public class Entertainment : Disk
    {

        public string Runtime { get; set; }


        public Entertainment(string Type, string ID, string Desc, double Price, int Qty,
           string ReleaseDate,
           int NumDisks, int Size, string TypeDisk,
           string RunTime) : base(Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk)
        {
            this.Runtime = RunTime;
        }

        public override string getDisplayText(string Sep)
        {
            return base.getDisplayText(Sep) + Sep + this.TypeDisk;
        }

        public override string ToString()
        {
            return this.getDisplayText("\r\n");

        }

        public override String ToCSV()
        {
            return this.getDisplayText(",");
        }
    }
}