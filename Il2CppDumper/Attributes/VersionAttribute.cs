﻿using System;

namespace Il2CppDumper
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    class VersionAttribute : Attribute
    {
        public float Min { get; set; } = 0;
        public float Max { get; set; } = 99;
    }
}
