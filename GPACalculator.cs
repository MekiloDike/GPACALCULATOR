using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACALCULATOR
{
    internal class GPACalculator
    {
        public static decimal CalculateGpa(List<GPAModel> gPAModels)
        {
            //get total quality point
            var totalQualityPoint = TotalQualityPoint(gPAModels);
            //get total grade unit
            var totalGradeUnit = TotalGradeUnit(gPAModels);

            var gpa = (decimal)totalQualityPoint / totalGradeUnit;
            var roundedUpGpa = Math.Round(gpa, 2);
            return roundedUpGpa;
        }

        private static int TotalQualityPoint(List<GPAModel> gPAModels)
        { 
            int totalQualityPoint = 0;
            foreach(var model in gPAModels)
            {
                var qualityPoint = model.CourseUnitModel * model.GradeUnitModel;
                totalQualityPoint += qualityPoint;
            }
            return totalQualityPoint;
        }

        private static int TotalGradeUnit(List<GPAModel> gpaList)
        {
            int totalGradeUnit = 0;
            foreach(var model in gpaList)
            {
                totalGradeUnit += model.CourseUnitModel;                

            } 
            return totalGradeUnit;
        }    
    }



}
