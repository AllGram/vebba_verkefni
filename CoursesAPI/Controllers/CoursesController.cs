using System.Collections.Generic;
using System.Web.Http;
using CoursesAPI.Models;
using CoursesAPI.Services.DataAccess;
using CoursesAPI.Services.Models.Entities;
using CoursesAPI.Services.Services;

namespace CoursesAPI.Controllers
{
	[RoutePrefix("api/courses")]
	public class CoursesController : ApiController
	{
		private readonly CoursesServiceProvider _service;

		public CoursesController()
		{
			_service = new CoursesServiceProvider(new UnitOfWork<AppDataContext>());
		}
		
		[Route("semester/{semester}")]
		public List<CourseInstanceDTO> GetCoursesOnSemester(string semester)
		{
			return _service.GetSemesterCourses(semester);
		}

        [HttpPost]
        [Route("{courseInstanceID:int}/projectgroup")]
        public void CreateProjectGroup(int courseInstanceID, CreateProjectGroupViewModel model)
        {
            _service.CreateProjectGroup(courseInstanceID, model);
            return;
        }

        [HttpPost]
        [Route("projectgroup/{projectGroupID:int}/project")]
        public void CreateProject(int projectGroupID, CreateProjectViewModel model)
        {
            _service.CreateProject(projectGroupID, model);
            return;
        }

        [HttpPost]
        [Route("grade/{projectID:int")]
        public void GiveGrades(int projectID, GiveGradesViewModel model)
        {
            _service.GiveGrades(projectID, model);
        }
	}
}
