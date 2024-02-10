
using GPACALCULATOR;

Console.WriteLine("My GPA Calculator");
string courseCode;
int courseUnit;
int courseScore;
string anotherCourse;
List<GPAModel> modelList = new List<GPAModel>();

do
{
    //get course code
    courseCode = GPAInput.InputCourseCode();

    //get course unit
    courseUnit = GPAInput.InputCourseUnit();

    //get course score
    courseScore = GPAInput.InputCourseScore();

    //add to the list to store
    modelList.Add(new GPAModel() 
        {
        CourseCodeModel = courseCode,
        CourseUnitModel = courseUnit,
        CourseScoreModel = courseScore,
    });

   anotherCourse = GPAInput.AddAnotherCourse();
}
while (anotherCourse == "Y");

// get grade
GradeScale scale = new GradeScale();
modelList = scale.GetGrade(modelList);

// get grade point
modelList = scale.GradePoint(modelList);

//calculate GPA
var calculategpa = GPACalculator.CalculateGpa(modelList);

Console.WriteLine("|-------------|-----------|-----|----------|-------------|");
Console.WriteLine("|COURSE & CODE|COURSE UNIT|GRADE|GRADE-UNIT|REMARK       |");

foreach (GPAModel model in modelList)
{
    Console.WriteLine("|-------------|-----------|-----|----------|-------------|");
    Console.WriteLine($"|{model.CourseCodeModel}      |{model.CourseUnitModel}          |{model.GradeMarkModel}    |{model.GradeUnitModel}         |{model.Remark}");

}
Console.WriteLine("|--------------------------------------------------------|");
Console.WriteLine();
Console.WriteLine($"Your GPA is = {calculategpa} to 2 decimal places.");



