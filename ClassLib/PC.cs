using System;

namespace ClassLib
{
	/*
	●	Создать библиотеку классов с именем «ClassLib». 
		○	В библиотеке «ClassLib» создать класс с именем «РС», описывающий компьютер. Данный класс должен включать:  
			■	3–4 поля (марка, серийный номер и т.д.),  
			■	свойства (к каждому полю),  
			■	конструкторы (по умолчанию, с параметрами),  
			■	методы, моделирующие функционирование ПЭВМ (включение/выключение, перегрузку).
	*/
	[Serializable]
	public class PC
	{
		public string MadeBy { get; set; }
		public string SerialNum { get; set; }
		public string Processor { get; set; }
		public int SSD_GB { get; set; }

		public PC() { MadeBy = "Samsung"; SerialNum = "ABC123456789"; Processor = "Intel Core i7 7730"; SSD_GB = 512; }
		public PC(string madeby,string serialnum, string proc, int ssd) { MadeBy = madeby; SerialNum = serialnum; Processor = proc; SSD_GB = ssd; }

		public void TurnOn()
		{
			Console.WriteLine("PC is switched on");
		}

		public void TurnOff()
		{
			Console.WriteLine("PC is switched off");
		}

		public void Reboot()
		{
			Console.WriteLine("PC is rebooting");
		}
	}
}
