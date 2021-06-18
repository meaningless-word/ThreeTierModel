using System;
using System.Collections.Generic;

namespace SkillFactory.ToDoList.Entities
{
	public class Example
	{
		/// <summary>
		/// Идентификатор - обязательное поле у каждой сущности
		/// </summary>
		public int Id { get; set; }

		public string Name { get; set; }

		public List<int> Vakues { get; set; }
	}
}
