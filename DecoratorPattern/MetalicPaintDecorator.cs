using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	public class MetalicPaintDecorator : AdditionalEquipmentDecorator
	{
		Car car = null;

		public MetalicPaintDecorator(Car car)
		{
			this.car = car;
		}

		public override string AdditionalEquipment()
		{
			return this.car.AdditionalEquipment().TrimEnd('.') + " and metalic paint.";
		}
	}
}
