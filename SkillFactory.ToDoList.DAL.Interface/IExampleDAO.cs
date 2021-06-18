using SkillFactory.ToDoList.Entities;
using System;
using System.Collections;

namespace SkillFactory.ToDoList.DAL.Interface
{
	public interface IExampleDAO
	{
		int Add(Example example);

		IEnumerable GetAll();

		Example GetById(int id);
	}
}
