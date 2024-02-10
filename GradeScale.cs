using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using static GPACALCULATOR.Enums;
using static System.Formats.Asn1.AsnWriter;

namespace GPACALCULATOR
{
    internal class GradeScale
    {
        public List<GPAModel> GetGrade(List<GPAModel> gpaModels)
        {
            foreach(var model in gpaModels)
            {
                if (model.CourseScoreModel >= 70 && model.CourseScoreModel <= 100)
                {
                    model.GradeMarkModel = 'A';
                }
                else if (model.CourseScoreModel >= 60 && model.CourseScoreModel <= 69)
                {
                    model.GradeMarkModel = 'B';
                }
                else if (model.CourseScoreModel >= 50 && model.CourseScoreModel <= 59)
                {
                    model.GradeMarkModel = 'C';
                }

                else if (model.CourseScoreModel >= 45 && model.CourseScoreModel <= 49)
                {
                    model.GradeMarkModel = 'D';
                }
                else if (model.CourseScoreModel >= 40 && model.CourseScoreModel <= 44)
                {
                    model.GradeMarkModel = 'E';
                }
                else if (model.CourseScoreModel >= 0 && model.CourseScoreModel <= 39)
                {
                    model.GradeMarkModel = 'F';
                }
                else
                    throw new Exception("score should be between zero and hundred");
            }
            return gpaModels;
        }

        public List<GPAModel> GradePoint(List<GPAModel> gpaModels)
        {
            foreach(var mode in gpaModels)
            {
                if (mode.GradeMarkModel == 'A')
                {
                    mode.GradeUnitModel = 5;
                    mode.Remark =  Remark.Excellent.ToString();
                }
                else if (mode.GradeMarkModel  == 'B')
                {
                    mode.GradeUnitModel = 4;
                    mode.Remark = Remark.Very_Good.ToString();
                }
                else if (mode.GradeMarkModel  == 'C')
                {
                    mode.GradeUnitModel = 3;
                    mode.Remark = Remark.Good.ToString();
                }
                else if (mode.GradeMarkModel  == 'D')
                {
                    mode.GradeUnitModel = 2;
                    mode.Remark = Remark.Pass.ToString();
                }
                else if (mode.GradeMarkModel  == 'E')
                {
                    mode.GradeUnitModel = 1;
                    mode.Remark = Remark.Fair.ToString();
                }
                else
                {
                    mode.GradeUnitModel = 0;
                    mode.Remark = Remark.Fail.ToString();
                }
            }
            return gpaModels;
           
        }

        public int Grade1(char grade)
        {
            switch (grade)
            {
                case 'A':
                    return 5;
                case 'B':
                    return 4;
                case 'C':
                    return 3;
                case 'D':
                    return 2;
                case 'E':
                    return 1;
                default:
                    return 0;
            }
        }
        public int Grade2(char grade)
        {
            var gradePoint = grade switch
            {
                'A' => 5,
                'B' => 4,
                'C' => 3,
                'D' => 2,
                'E' => 1,
                'F' => 0,
                _ => throw new NotImplementedException(),
            };
            return gradePoint;
        }
    }
}
