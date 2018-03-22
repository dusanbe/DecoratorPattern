using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	public class SAAB : Car
	{
		public override string AdditionalEquipment()
		{
			return "This " + this.GetType().Name + " comes with base equipment.";
		}
	}
}
