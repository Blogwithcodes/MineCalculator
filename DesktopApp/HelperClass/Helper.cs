using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.HelperClass
{
    public enum Arms
    {
        Infantry=1,
        Engineer=2,
        PMF=3
    }
    public enum Terrain
    {
        Mountains = 1,
        Plains = 2,
        Deserts = 3
    }
    public static class Helper
    {
        public static int GetRateOfLaying(Arms arms, Terrain terrain)
        {
            if(arms==Arms.Engineer && terrain == Terrain.Plains)
            {
                return 700;
            } 
            if(arms==Arms.Infantry && terrain == Terrain.Plains)
            {
                return 500;
            } 
            if(arms==Arms.PMF && terrain == Terrain.Plains)
            {
                return 350;
            } 
            if(arms==Arms.Engineer && terrain == Terrain.Deserts)
            {
                return 500;
            }
            if(arms==Arms.Infantry && terrain == Terrain.Deserts)
            {
                return 350;
            } 
            if(arms==Arms.PMF && terrain == Terrain.Deserts)
            {
                return 200;
            }
            if(arms==Arms.Engineer && terrain == Terrain.Mountains)
            {
                return 300;
            }
            if(arms==Arms.Infantry && terrain == Terrain.Mountains)
            {
                return 200;
            }
            if(arms==Arms.PMF && terrain == Terrain.Mountains)
            {
                return 100;
            }
            return 1;
           
        }


        public static void ExportToCsv(List<ExportCSVModel> records, string outputPath)
        {
            var csvBuilder = new StringBuilder();

            // Add the header row
            csvBuilder.AppendLine("Distance From,Distance To,Distance,GRef,Bearing,Latitude,Longitude");

            // Add the data rows
            foreach (var record in records)
            {
                csvBuilder.AppendLine($"{record.DistanceFrom},{record.DistanceTo},{record.Distance},{record.GRef},{record.Bearing},{record.Latitude},{record.Longitude}");
            }

            // Write the CSV content to a file
            File.WriteAllText(outputPath, csvBuilder.ToString());
        }
    }

    public class ExportCSVModel
    {
        public string DistanceFrom { get; set; }
        public string DistanceTo { get; set; }
        public int Distance { get; set; }
        public string GRef { get; set; }
        public string Bearing { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}

