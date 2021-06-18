using SkillFactory.ToDoList.BLL;
using SkillFactory.ToDoList.BLL.Interface;
using SkillFactory.ToDoList.DAL;
using SkillFactory.ToDoList.DAL.Interface;
using System;

namespace SkillFactory.ToDoList.IOC
{
	// есть такой паттерн DependencyResolver. здесь реализуется его фрагмент
	// это будет один суперкласс, который будет знать обо всм, кроме PL и Entities
	public static class DependencyResolver
	{
		private static IExampleDAO exampleDAO { get; } = new ExampleDAO();
		public static IExampleLogic exampleLogic { get; } = new ExampleLogic(exampleDAO);

		// свойства объявлены только с get'ом для того, чтобы извне нельзя было поменять текущий класс
	}
}
