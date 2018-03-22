using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start assembling... \n");

			Car cady = new Cadilac();
			Console.WriteLine(cady.AdditionalEquipment());

			IList<Car> carBatch = new List<Car>();

			carBatch.Add(new MetalicPaintDecorator(new Cadilac()));
			carBatch.Add(new MetalicPaintDecorator(new AirConditionerDecorator(new Cadilac())));
			carBatch.Add(new AirConditionerDecorator(new SAAB()));
			carBatch.Add(new SAAB());

			foreach (var car in carBatch)
			{
				Console.WriteLine(car.AdditionalEquipment());
			}

			Console.ReadLine();
		}
	}
}
