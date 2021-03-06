﻿// Decompiled with JetBrains decompiler
// Type: FML.VROC
// Assembly: Basic_fml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E9284717-8834-4B37-BC08-9823918209B3
// Assembly location: E:\Development\TradingProjects\Easy Financial Chart3.5 .net 4.5\StockExpert\NB.StockStudio\bin\Debug\dllReference\formula\Basic_fml.dll

using NB.StockStudio.Foundation;
using NB.StockStudio.Foundation.DataProvider;

namespace FML
{
  public class VROC : FormulaBase
  {
    private double N;

    public VROC()
    {
      base.\u002Ector();
      this.AddParam("N", 12.0, 2.0, 300.0);
    }

    public virtual FormulaPackage Run(IDataProvider dp)
    {
      this.DataProvider = (__Null) dp;
      return new FormulaPackage(new FormulaData[1]
      {
        FormulaData.op_Multiply(FormulaData.op_Division(FormulaData.op_Subtraction(this.get_VOL(), FormulaBase.REF(this.get_VOL(), this.N)), FormulaBase.REF(this.get_VOL(), this.N)), FormulaData.op_Implicit(100.0))
      }, "");
    }
  }
}
