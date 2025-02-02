//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleRegression.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("CPU"), LoadColumn(0)]
        public string CPU { get; set; }


        [ColumnName("GHz"), LoadColumn(1)]
        public float GHz { get; set; }


        [ColumnName("GPU"), LoadColumn(2)]
        public string GPU { get; set; }


        [ColumnName("RAM"), LoadColumn(3)]
        public float RAM { get; set; }


        [ColumnName("RAMType"), LoadColumn(4)]
        public string RAMType { get; set; }


        [ColumnName("Screen"), LoadColumn(5)]
        public float Screen { get; set; }


        [ColumnName("Storage"), LoadColumn(6)]
        public float Storage { get; set; }


        [ColumnName("SSD"), LoadColumn(7)]
        public bool SSD { get; set; }


        [ColumnName("Weight"), LoadColumn(8)]
        public float Weight { get; set; }


        [ColumnName("Price"), LoadColumn(9)]
        public float Price { get; set; }


    }
}
