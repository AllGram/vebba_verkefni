using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using CoursesAPI.Models;
using CoursesAPI.Services.DataAccess;
using CoursesAPI.Services.Models.Entities;
using CoursesAPI.Services.Extensions;

namespace CoursesAPI.Services.Services
{
	public class CoursesServiceProvider
	{
		private readonly IUnitOfWork _uow;

		private readonly IRepository<Course>            _courses;
		private readonly IRepository<CourseInstance>    _courseInstances;
        private readonly IRepository<Grade>             _grades;
        private readonly IRepository<Person>            _persons;
        private readonly IRepository<Project>           _projects;
        private readonly IRepository<ProjectGroup>      _projectGroups;
        private readonly IRepository<Semester>          _semesters;

		public CoursesServiceProvider(IUnitOfWork uow)
		{
			_uow = uow;

            _courses              = _uow.GetRepository<Course>();
			_courseInstances      = _uow.GetRepository<CourseInstance>();
            _grades               = _uow.GetRepository<Grade>(); 
            _persons              = _uow.GetRepository<Person>();
            _projects             = _uow.GetRepository<Project>();
            _projectGroups        = _uow.GetRepository<ProjectGroup>();
            _semesters            = _uow.GetRepository<Semester>();
		}

		public List<CourseInstanceDTO> GetSemesterCourses(string semester)
		{
			// TODO 
			return null;
		}

        public void CreateProjectGroup(int courseInstanceID, CreateProjectGroupViewModel model)
        {
            // We need to check if the course actually exists, if it doesn't then our extensions throws an exception
            var courseInstance = _courseInstances.GetCourseInstanceByID(courseInstanceID);

            var projectGroup = new ProjectGroup
            {
                Name = model.Name,
                CourseInstanceID = courseInstanceID,
                NumberOfProjectsThatCount = model.NumberOfProjectsThatCount
            };

            _projectGroups.Add(projectGroup);
            _uow.Save();
        }
	}
}
