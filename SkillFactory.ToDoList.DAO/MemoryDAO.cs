using SkillFactory.ToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.ToDoList.DAL
{
	/// <summary>
	/// это класс для эмуляции хранения данных
	/// </summary>
	public static class MemoryDAO
	{
		public static Dictionary<int, Example> examples = new Dictionary<int, Example>();
	}
}
