﻿using System;

namespace Utilitarian.FluentExcel.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FormulaAttribute : Attribute
    {
        public FormulaType FormulaType { get; private set; }

        public FormulaAttribute()
        {
            FormulaType = FormulaType.Sum;
        }

        public FormulaAttribute(FormulaType formulaType)
        {
            FormulaType = formulaType;
        }
    }
}
