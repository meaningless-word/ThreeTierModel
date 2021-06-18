//using SkillFactory.ToDoList.BLL;
//using SkillFactory.ToDoList.BLL.Interface;
//using SkillFactory.ToDoList.DAL;
using SkillFactory.ToDoList.IOC;
using System;
using System.Collections.Generic;

namespace SkillFactory.ToDoList.ConsolePL
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			// сначала пример "плохого" связывания, что означает, что слою PL приходится показывать слой DAL (там у нас DAO лежат, а без этого не получится сделать экземпляр)
			// когда как в "хорошем" слой PL может видеть только BLL
			IExampleLogic exampleLogic = new ExampleLogic(new ExampleDAO());

			var id = exampleLogic.Add(new Entities.Example() { Name = "первый", Vakues = new List<int> { 1, 1 } });

			var example = exampleLogic.GetById(id);
			Console.WriteLine(example.Name);
			*/

			// для хорошего связывания нам понадоюится суперкласс, который будет знать обо всём. это IOC (видимо, I/O Container)
			// размещаться он юудет в COMMON'е
			// нужно обратить внимание, что сейчас нам больше не нужны ссылки на все сборки за исключением ресолвера
			var exampleLogic = DependencyResolver.exampleLogic;
		}
	}
}
