using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{

	public class ContactosPageMenuItem
	{
		public ContactosPageMenuItem()
		{
			TargetType = typeof(ContactosPageDetail);
		}
		public int Id { get; set; }
		public string Title { get; set; }

		public Type TargetType { get; set; }
	}
}