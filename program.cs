using static System.Console;
using System.IO;
using Microsoft.ML.Data;
using Microsoft.ML;
using System.Data;

public class Input
    {
    [LoadColumn(0)] public string? Sex { get; set; }
    [LoadColumn(1)] public float Length { get; set; }
    [LoadColumn(2)] public float Diameter { get; set; }
    [LoadColumn(3)] public float Height { get; set; }
    [LoadColumn(4)] public float Whole { get; set; }
    [LoadColumn(5)] public float Shucked { get; set; }
    [LoadColumn(6)] public float Viscera { get; set; }
    [LoadColumn(7)] public float Shell { get; set; }
    [LoadColumn(8)] public float Rings { get; set; }
    [LoadColumn(9)] public float testvalues { get; set; }
    }
class Output
    {
     public string? Sex { get; set; }
     public float Length { get; set; }
     public float Diameter { get; set; }
     public float Height { get; set; }
     public float Whole { get; set; }
     public float Shucked { get; set; }
     public float Viscera { get; set; }
     public float Shell { get; set; }
     public float Rings { get; set; }
     public float testvalues { get; set; }
    }



class Program
    {
    static int i = 0;
    static int jisuan()
        {
        i++;
        return i; 
        }
    static void Main(string[] args)
        {
        MLContext context = new();//创建环境
        string datapath = @"G:\VSstudio2022项目\C#项目\ML.net-DataOperation\ML.net-DataOperation\abalone.txt";
        IDataView dataview = context.Data.LoadFromTextFile<Input>(datapath, separatorChar: ',',hasHeader:true);
        string datapath_1 = @"G:\VSstudio2022项目\C#项目\ML.net-DataOperation\ML.net-DataOperation\abalone_1.txt";
        FileStream file_1 = File.OpenWrite(datapath_1);
        context.Data.SaveAsText(dataview, file_1, separatorChar: ',');

        // //不完美预览 无法显示行标签
        // var preview = dataview.Preview(maxRows: 10);
        // foreach (var row in preview.RowView)
        //     {
        //     foreach (var column in row.Values)
        //         {
        //         Write($"{column.Value}\t");
        //         }
        //     WriteLine();
        //     }
        
        //获取某列 返回数组
        //var Length = dataview.GetColumn<float>("Length");
        //foreach (var item in Length)
        //    {
        //    WriteLine($"{item}");
        //    }



        }
    }
