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





public static Array Combine(params Array[] arrays)
{
    if (arrays.Length == 0)
        return null;

    // Определяем тип по первому массиву
    Type elementType = arrays[0].GetType().GetElementType();
    int totalLength = 0;

    // Проверяем, что все массивы одного типа и не null
    foreach (var arr in arrays)
    {
        if (arr == null || arr.GetType().GetElementType() != elementType)
            return null;
        totalLength += arr.Length;
    }

    // Создаём итоговый массив
    Array result = Array.CreateInstance(elementType, totalLength);
    int index = 0;
    foreach (var arr in arrays)
        foreach (var item in arr)
            result.SetValue(item, index++);

    return result;
}
