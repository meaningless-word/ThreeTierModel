using SkillFactory.ToDoList.DAL.Interface;
using SkillFactory.ToDoList.Entities;
using System.Collections;
using System.Linq;

namespace SkillFactory.ToDoList.DAL
{
	public class ExampleDAO : IExampleDAO
	{
		/// <summary>
		/// метод добавления новой записи (C из CRUD)
		/// </summary>
		/// <param name="example">экземпляр класса</param>
		/// <returns>идентификатор новой записи</returns>
		public int Add(Example example)
		{
			// для начала в хранилище ищется запись с максимальным Id, чтобы образовать от него следующий по порядку, обеспечив уникальность
			int id = GetLastId() + 1;
			example.Id = id;
			MemoryDAO.examples.Add(id, example);
			return id;
		}

		/// <summary>
		/// метод чтения всех записей (R из CRUD)
		/// </summary>
		/// <returns>список записей</returns>
		public IEnumerable GetAll()
		{
			return MemoryDAO.examples.Values;
		}

		/// <summary>
		/// метод чтения конкретной записи (R из CRUD)
		/// </summary>
		/// <param name="id">идентификатор</param>
		/// <returns>эеземпляр, соответствующий идентификатору</returns>
		public Example GetById(int id)
		{
			if(!MemoryDAO.examples.TryGetValue(id, out var example))
			{
				return null;
			}
			return example;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private int GetLastId()
		{
			int lastId;
			if (MemoryDAO.examples.Count == 0)
			{
				lastId = 0;
			}
			else
			{
				// вся эта проверка нудна для того, чтобы не дать Max'у бегать по пустой коллекции, чтоб не упал
				lastId = MemoryDAO.examples.Keys.Max();
			}
			return lastId;
		}
	}
}
