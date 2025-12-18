# Gluing-arrays
Склейка массивов (курс C#) - Наследование


## Задание:

Реализуйте метод Combine, который возвращает массив, собранный из переданных массивов.

Для того, чтобы создать новый массив, используйте статический метод Array.CreateInstance, принимающий тип элемента массива.

Для того, чтобы узнать тип элементов в переданном массиве, используйте myArray.GetType().GetElementType().

Проверьте, что типы элементов совпадают во всех переданных массивах!

Если результирующий массив создать нельзя, возвращайте null.

## Изначально данный код:

public static void Main()
{
	var ints = new[] { 1, 2 };
	var strings = new[] { "A", "B" };

	Print(Combine(ints, ints));
	Print(Combine(ints, ints, ints));
	Print(Combine(ints));
	Print(Combine());
	Print(Combine(strings, strings));
	Print(Combine(ints, strings));
}

static void Print(Array array)
{
	if (array == null)
	{
		Console.WriteLine("null");
		return;
	}
	for (int i = 0; i < array.Length; i++)
		Console.Write("{0} ", array.GetValue(i));
	Console.WriteLine();
}
