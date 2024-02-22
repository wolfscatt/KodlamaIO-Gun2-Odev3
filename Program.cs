using KodlamaIOGün2Ödev3.Business.Concrete;
using KodlamaIOGün2Ödev3.DAL.Concrete;
using KodlamaIOGün2Ödev3.Entity.Concrete;

var courseList = new List<Course>
{
    new Course { Id=1, CategoryId=1, CourseName="Senior Yazılım Geliştirici Yetiştirme Kampı .NET", CourseInstructor="Engin Demiroğ" },
    new Course { Id=2, CategoryId=1, CourseName="Yazılım Geliştirici Yetiştirme Kampı C#, Angular", CourseInstructor="Engin Demiroğ" },
    new Course { Id=3, CategoryId=1, CourseName="Yazılım Geliştirici Yetiştirme Kampı Python&Selenium", CourseInstructor="Halit Enes Kalaycı" },
    new Course { Id=4, CategoryId=1, CourseName="2024 Yazılım Geliştirici Yetiştirme Kampı C#", CourseInstructor="Engin Demiroğ" },
    new Course { Id=5, CategoryId=1, CourseName="Yazılım Geliştirici Yetiştirme Kampı JavaScript", CourseInstructor="Engin Demiroğ" },
};

var categoryList = new List<Category>
{
    new Category { Id=1, CategoryName="Yazılım" },
    new Category { Id=2, CategoryName="Tasarım" },
    new Category { Id=3, CategoryName="Veri Bilimi" },
};

var instructorList = new List<Instructor>
{
    new Instructor { Id=1, InstructorName="Engin Demiroğ" },
    new Instructor { Id=2, InstructorName="Halit Enes Kalaycı" },
};

var courseDal = new CourseDal(courseList);
var categoryDal = new CategoryDal(categoryList);
var instructorDal = new InstructorDal(instructorList);

var courseManager = new CourseManager(courseDal);
var categoryManager = new CategoryManager(categoryDal);
var instructorManager = new InstructorManager(instructorDal);

var courses = courseManager.GetAll();

var newCourse = new Course { Id=6, CategoryId=1, CourseName="Yazılım Geliştirici Yetiştirme Kampı Java", CourseInstructor="Engin Demiroğ" };
courseManager.Add(newCourse);

//foreach (var course in courses)
//{
//    Console.WriteLine(course);
//}

var deletedCourse = courseManager.Delete(newCourse);
Console.WriteLine($"Silinen Course Detayları -> {deletedCourse}");
foreach (var course in courses)
{
    Console.WriteLine(course);
}