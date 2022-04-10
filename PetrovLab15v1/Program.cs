using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab15v1
{
    class Program
    {
        //Разработать интерфейс ISeries генерации ряда чисел.Интерфейс содержит следующие элементы:
        //метод void setStart(int x) - устанавливает начальное значение
        //метод int getNext() - возвращает следующее число ряда
        //метод void reset() - выполняет сброс к начальному значению
        //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
        //В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
        static void Main(string[] args)
        {
			// Ввод данных пользователем и проверки опустил для сокращения кода. Просто ввёл константы для разнообразия.
			const int arithStep = 2; // Шаг
			const int arithStart = 4; // Первое (начальное) число
			const int arithLength = 5; // Длина ряда
			var arithProgression = new ArithProgression(arithStep);
			arithProgression.setStart(arithStart);
			for (int i = 0; i < arithLength; i++)
			{
				int value = arithProgression.getNext();
				Console.WriteLine(value);
			}

			Console.WriteLine();

			const int geomStep = 3; // Шаг
			const int geomStart = 1; // Первое (начальное) число
			const int geomLength = 5; // Длина ряда
			var geomProgression = new GeomProgression(geomStep);
			geomProgression.setStart(geomStart);
			for (int i = 0; i < geomLength; i++)
			{
				int value = geomProgression.getNext();
				Console.WriteLine(value);
			}
			Console.ReadKey();
		}
		public interface ISeries // Интерфейс
		{
			void setStart(int x);
			int getNext();
			void reset();
		}

		public class ArithProgression : ISeries // Класс реализующий интерфейс
		{
			public ArithProgression(int step)
			{
				Step = step;
			}

			private int index;
			private int start;
			private int Step;

			public int getNext()
			{
				return start + Step * index++;
			}

			public void reset()
			{
				index = 0;
			}

			public void setStart(int x)
			{
				start = x;
				index = 0;
			}
		}

		public class GeomProgression : ISeries // Класс реализующий интерфейс
		{
			public GeomProgression(int denominator)
			{
				step = denominator;
			}

			private int index;
			private int start;
			private int step;

			public int getNext()
			{
				return start * (int)Math.Pow(step, index++);
			}

			public void reset()
			{
				index = 0;
			}

			public void setStart(int x)
			{
				start = x;
				index = 0;
			}
		}
	}
}
