using CleanArch.Domain.Models;
using CleanArch.Domain.Models.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
	public class CourseRepository : ICourseRepository
	{
		private UniversityDbContext _ctx;

		public CourseRepository(UniversityDbContext ctx)
		{
			_ctx = ctx;
		}

		public IEnumerable<Course> GetCourses()
		{
			return _ctx.Courses;
		}
	}
}
