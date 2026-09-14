// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();

// Console.WriteLine("Границы дробных типов");
// Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

// Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);

// Console.WriteLine($"255 + 1 для byte = {overflowed}");
// Console.WriteLine();

// Console.WriteLine();
// Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter; 

// Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");

// Console.WriteLine();
// Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// System.Console.WriteLine();
// System.Console.WriteLine("var");

// var studentAge = 20;
// var gpa = 4.75;
// var fullName = "Смирнова А.С.";

// System.Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод текста");

// System.Console.WriteLine("Введите ваше имя: ");
// string enteredName = Console.ReadLine();

// System.Console.WriteLine("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();

// System.Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод чисел: Convert и Parse");

// System.Console.Write("Введите ваш год рождения: ");
// string birthInput = Console.ReadLine();

// int birthConvert = Convert.ToInt32(birthInput);
// int birthParse = int.Parse(birthInput);

// System.Console.WriteLine($"Convert.ToInt32: {birthInput}");
// System.Console.WriteLine($"int.Parse:       {birthParse}");
// System.Console.WriteLine($"В 2030 году вам будет: {2030 - birthConvert} лет");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: TryParse");

// Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int
// booksCount);

// Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount: {booksCount}");

// Console.Write("Введите имя и фамилию: ");
// string fio = Console.ReadLine();
// Console.Write("Введите группу: ");
// string group = Console.ReadLine();
// Console.Write("Введите год рождения: ");
// string birthInput = Console.ReadLine();
// Console.Write("Введите средний балл: ");
// string gradeInput = Console.ReadLine();
// Console.Write("Введите любимую букву: ");
// char favorite = Console.ReadLine()[0];

// int birthParse = int.Parse(birthInput);
// double gradeParse = double.Parse(gradeInput);
// bool is4 = false;
// if (gradeParse >= 4.0)
// {
//     is4 = true;
// }

// System.Console.WriteLine($"     Анкета");
// System.Console.WriteLine($"{fio}, группа {group}");
// System.Console.WriteLine($"Год рождения: {birthParse} (в 2030 будет {2030 - birthParse} год)");
// System.Console.WriteLine($"Средний балл: {gradeInput}");
// System.Console.WriteLine($"Балл >= 4.0: {is4}");
// System.Console.WriteLine($"Любимая буква: {favorite}");

Console.Write("Введите рост в метрах: ");
double height = double.Parse(Console.ReadLine());

Console.Write("Введите вес в килограммах: ");
double weight = double.Parse(Console.ReadLine());

double bmi = weight / (height * height);

Console.WriteLine($"ИМТ: {bmi:F2}");

Console.WriteLine();

// Console.Write("Введите фамилию: ");
// string surname = Console.ReadLine();

// Console.Write("Введите имя: ");
// string name = Console.ReadLine();

// char firstLetter = name[0];

// Console.WriteLine($"{surname} {firstLetter}.");