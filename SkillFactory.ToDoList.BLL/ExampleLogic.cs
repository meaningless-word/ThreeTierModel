using SkillFactory.ToDoList.BLL.Interface;
using SkillFactory.ToDoList.DAL.Interface;
using SkillFactory.ToDoList.Entities;
using System;
using System.Collections;

namespace SkillFactory.ToDoList.BLL
{
	public class ExampleLogic : IExampleLogic
	{
		private readonly IExampleDAO _exampleDAO;

		public ExampleLogic(IExampleDAO exampleDAO)
		{
			_exampleDAO = exampleDAO;
		}

		public int Add(Example example)
		{
			// поскольку приведенный пример очень прост, то метод добавления в логике должен просто "перекинуть" свой параметр методу в DAL
			// чтобы показать, что логика таки должна присутствовать, устроим проверку
			if (example.Name.Length < 3)
				throw new ArgumentException("Должно быть 3 или более символа");
			return _exampleDAO.Add(example);
		}

		public IEnumerable GetAll()
		{
			return _exampleDAO.GetAll();
		}

		public Example GetById(int id)
		{
			return _exampleDAO.GetById(id);
		}
	}
}
