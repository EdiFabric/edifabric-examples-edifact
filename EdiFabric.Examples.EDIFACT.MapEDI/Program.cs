﻿using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.MapEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(TrialLicense.SerialKey);

            //  Map using XSLT
            EDIToCustomObjectWithXslt.Run();

            //  Map using AutoMapper
            EDIToCustomObjectWithAutoMapper.Run();
        }
    }
}
