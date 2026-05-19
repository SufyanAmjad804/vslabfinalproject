using Microsoft.EntityFrameworkCore;
using StudentDashboard.Web.Data;
using StudentDashboard.Web.Models;

namespace StudentDashboard.Web.Services;

public class SchoolService : ISchoolService
{
    private readonly IDbContextFactory<AppDbContext> dbFactory;

    public SchoolService(IDbContextFactory<AppDbContext> dbFactory)
    {
        this.dbFactory = dbFactory;
    }

    public async Task<ReportSummary> GetSummaryAsync()
    {
        await using var db = await dbFactory.CreateDbContextAsync();

        var attendanceTotal = await db.AttendanceRecords.CountAsync();
        var presentTotal = await db.AttendanceRecords.CountAsync(item => item.Status == "Present");
        var gradeRecords = await db.GradeRecords.AsNoTracking().ToListAsync();

        return new ReportSummary
        {
            TotalStudents = await db.Students.CountAsync(),
            TotalCourses = await db.Courses.CountAsync(),
            TotalEnrollments = await db.Enrollments.CountAsync(),
            AttendancePercentage = attendanceTotal == 0 ? 0 : Math.Round((decimal)presentTotal / attendanceTotal * 100, 2),
            AverageGradePercentage = gradeRecords.Count == 0 ? 0 : Math.Round(gradeRecords.Average(item => item.Percentage), 2),
            PendingFees = await db.FeeInvoices.Where(item => !item.IsPaid).SumAsync(item => item.Amount),
            OpenTickets = await db.SupportTickets.CountAsync(item => item.Status != "Closed"),
            UnreadNotifications = await db.Notifications.CountAsync(item => !item.IsRead)
        };
    }

    public async Task<List<Student>> GetStudentsAsync(string? search = null)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var query = db.Students.AsNoTracking().AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            var term = search.Trim().ToLower();
            query = query.Where(student =>
                student.FirstName.ToLower().Contains(term) ||
                student.LastName.ToLower().Contains(term) ||
                student.Email.ToLower().Contains(term) ||
                student.StudentNumber.ToLower().Contains(term) ||
                student.ProgramName.ToLower().Contains(term));
        }

        return await query.OrderBy(student => student.FirstName).ToListAsync();
    }

    public async Task<Student> SaveStudentAsync(Student student)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        if (student.Id == 0)
        {
            db.Students.Add(student);
        }
        else
        {
            db.Students.Update(student);
        }

        await db.SaveChangesAsync();
        return student;
    }

    public async Task DeleteStudentAsync(int id)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var student = await db.Students.FindAsync(id);
        if (student is null)
        {
            return;
        }

        db.Students.Remove(student);
        await db.SaveChangesAsync();
    }

    public async Task<List<Course>> GetCoursesAsync(string? search = null)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var query = db.Courses.AsNoTracking().AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            var term = search.Trim().ToLower();
            query = query.Where(course =>
                course.Code.ToLower().Contains(term) ||
                course.Title.ToLower().Contains(term) ||
                course.InstructorName.ToLower().Contains(term));
        }

        return await query.OrderBy(course => course.Code).ToListAsync();
    }

    public async Task<Course> SaveCourseAsync(Course course)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        if (course.Id == 0)
        {
            db.Courses.Add(course);
        }
        else
        {
            db.Courses.Update(course);
        }

        await db.SaveChangesAsync();
        return course;
    }

    public async Task DeleteCourseAsync(int id)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var course = await db.Courses.FindAsync(id);
        if (course is null)
        {
            return;
        }

        db.Courses.Remove(course);
        await db.SaveChangesAsync();
    }
