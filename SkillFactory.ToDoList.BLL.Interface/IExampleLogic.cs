using SkillFactory.ToDoList.Entities;
using System;
using System.Collections;

namespace SkillFactory.ToDoList.BLL.Interface
{
	public interface IExampleLogic
	{
		int Add(Example example);

		IEnumerable GetAll();

		Example GetById(int id);
	}
}
