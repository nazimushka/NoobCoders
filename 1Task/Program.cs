// namespace ConsoleLesson4;

        //1.1 Пример программы без условных конструкций
        {
            Console.WriteLine("Введите первое слагаемое: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе слагаемое: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            return;
        }

        //1.2 Пример if
        {
            Console.WriteLine("Сегодня солнечно? Y/N");

            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("Тогда я одену солнечные очки и гавайские шорты!");
            }
            else
            {
                Console.WriteLine("Тогда лучше я оденусь потеплее.");
            }
            return;
        }

        //1.3 true и false в условие, для обработки работы конкретной ветки.
        {
            if (true)
            {
                //Всегда будет выполнятся этот вариант
            }
            else
            {
                //Этот вариант никогда не выполнится с этим условием
            }




            if (false)
            {
                //Этот вариант никогда не выполнится с этим условием
            }
            else
            {
                //Всегда будет выполнятся этот вариант
            }
            return;
        }

        //2.1 Операторы сравнения.
        {
            int a = 5, b = 6;
            Console.WriteLine($"{a} = {b}  ? - " + (a == b)); // == равен или нет
            Console.WriteLine($"{a} != {b} ? - " + (a != b)); // != не равенство
            Console.WriteLine($"{a} > {b}  ? - " + (a > b));
            Console.WriteLine($"{a} < {b}  ? - " + (a < b));

            b = 5; //Различие резултатов у операторов </<= и >/>=
            Console.WriteLine($"\n{a} < {b}  ? - " + (a < b));
            Console.WriteLine($"{a} <= {b} ? - " + (a <= b));
            Console.WriteLine($"{a} > {b}  ? - " + (a > b));
            Console.WriteLine($"{a} >= {b} ? - " + (a >= b));

            string zorro = "Алехандро"; // Пример работы оператора сравнения с типом данных string
            Console.WriteLine($"Под масской Зорро Кевин? - " + (zorro == "Кевин"));
            Console.WriteLine($"Под масской Зорро Алехандро? - " + (zorro == "Алехандро"));

            return;
        }

        //2.2
        {
            Console.Write("Добро пожаловать на наш аттракцион, вход на него разрешён от 10 лет. " +
                "Сколько тебе лет?: ");
            int i = int.Parse(Console.ReadLine());
            //bool isChild = i < 10;

            if (i < 10)
            {
                Console.WriteLine("Извини, ты не можешь пройти. УХОДИ!");
            }
            else
            {
                Console.WriteLine("Пожалуйста, проходи.");
            }
            return;
        }

        //2.3 Сложные версии выражений со сравнением.
        {
            Console.Write("Каждый чётный год, над этим местом пролетает комета. Какой сейчас год?: ");
            int i = int.Parse(Console.ReadLine());

            if ((i % 2) == 0)
            {
                Console.WriteLine("Смотри!");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine(" * * * * * * * * * * * * * ----@ * * * * * * * * * * * * ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            }
            else
            {
                Console.WriteLine("Не в этот раз =(");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            }
            return;
        }

        //3 Неполная запись, без else
        {

            bool isRaining = true; // запустить как с true, как и c false
            Console.WriteLine("Одеться.");

            if (isRaining)
            {
                Console.WriteLine("Взять зонт.");
            }                                      //Нам не обязательно прописывать else,
                                                   //если нам не нужнs альтернативный вариант

            Console.WriteLine("Выйти на улицу.");

            return;
        }

        //3.1 Без фигурных скобок, если у нас лишь один стейтмент.(только if)
        {

            bool isRaining = true;
            Console.WriteLine("Одеться.");

            if (isRaining)
                Console.WriteLine("Взять зонт.");

            Console.WriteLine("Выйти на улицу.");//уже не часть if


            // опасно! резиновые сапоги будут надеты даже если на улице тепло и светит солнце!
            if (isRaining)
                Console.WriteLine("Взять зонт.");
                Console.WriteLine("Одеть резиновые сапоги");

            Console.WriteLine("Выйти на улицу.");


            return;
        }

        //3.2 Без фигурных скобок, можно и при else.
        {

            bool isRaining = true;
            Console.WriteLine("Одеться.");

            if (isRaining)
                Console.WriteLine("Взять зонт.");
            else
                Console.WriteLine("Одеть солнечные очки.");

            Console.WriteLine("Выйти на улицу.");
            return;
        }

        //4. Область видимости на примере if/else
        {

            bool isRaining = true;
            Console.WriteLine("Одеться.");

            if (isRaining)
            {
                string step2 = "Взять зонт.";
            } //тут переменная step2 уничтожается
            else
            {
                string step2 = "Одеть солнечные очки."; //Мы можем тут второй раз за код, создать переменную,
                                                        //так как оба варианта никогда не выполняться вместе.
            } //тут переменная step2 уничтожается.
            //Console.WriteLine(step2);   //Ошибка, компилятор не знает в этом месте, о существовании переменной step2
            return;
        }

        //"Правильная" запись
        {

            bool isRaining = true;
            Console.WriteLine("Одеться.");

            string step2;
            if (isRaining)
            {
                step2 = "Взять зонт.";
            }
            else
            {
                step2 = "Одеть солнечные очки.";
            }
            Console.WriteLine(step2);
            return;
        }

        //4.1 Область видимости можно ограничивать по желанию с помощью {}
        {
            Console.Write("Как тебя зовут?: ");
            {
                string name = Console.ReadLine();
            }

            // ошибка!
            //Console.WriteLine($"Привет {name}!");
            return;
        }

        //5.1 Вложенность if/else
        {
            Console.Write("Добро пожаловать на наш ЭКСТРЕМАЛЬНЫЙ аттракцион, " +
                "вход на него разрешён от 10 до 60 лет. " +
                "Сколько тебе?: ");
            int i = int.Parse(Console.ReadLine());


            //if (10 < i < 60) // помня уроки математики, хочется написать так.
            //{
            //    Console.WriteLine("Пожалуйста, проходи.");
            //}
            //else
            //{
            //    Console.WriteLine("Извини, ты не можешь пройти. УХОДИ!");
            //}
            return;
        }

        //Вариант решения при помощи вложенного if.
        {
            Console.Write("Добро пожаловать на наш ЭКСТРЕМАЛЬНЫЙ аттракцион, " +
                "вход на него разрешён от 10 до 60 лет. " +
                "Сколько тебе?: ");
            int i = int.Parse(Console.ReadLine());

            if (10 < i)//Сперва убеждаемся, что человеку больше 10
            {
                if (i < 60)//Потом, что ему меньше 60.
                    Console.WriteLine("Пожалуйста, проходи.");
                else //Если 60 или больше, то не пускаем его, так как опасно
                    Console.WriteLine("Извини, ты не можешь пройти. УХОДИ!");
            }
            else
            {
                if (i < 7)//в блок else мы тоже можем писать ещё один if
                {
                    Console.WriteLine("Извини, ты не можешь пройти. Вот, возьми леденец.");
                }
                else if (i > 100)
                {
                    Console.WriteLine("Извините, Ваше участие в аттракционе невозможно!");
                }
                else
                {
                    Console.WriteLine("Извини, ты не можешь пройти. УХОДИ!");
                }
            }

            return;
        }

        // логические операторы И, ИЛИ, НЕ
        {
            bool first = true;
            bool second = false;
            bool resultAndOperator = first && second; // false
            bool resultOrOperator = first || second; // true
            Console.WriteLine($"{first} AND {second} is {resultAndOperator}");
            Console.WriteLine($"{first} OR {second} is {resultOrOperator}");

            Console.WriteLine($"{second} OR ({first} AND {second}) is {second || (first && second)}");

            int i = int.Parse(Console.ReadLine());
            bool isOdd = (i % 2 == 0);
            bool isEven = !isOdd;
            Console.WriteLine($"{i}: isOdd={isOdd}, isEven={isEven}");

            return;
        }

        //6 Альтернативный вариант записи аттракциона
        {
            Console.Write("Добро пожаловать на наш ЭКСТРИМАЛЬНЫЙ аттракцион, вход на него разрешён от 10 до 60 лет. Сколько тебе?: ");
            int i = int.Parse(Console.ReadLine());


            if ((10 < i) && (i < 60))// идентично 10 < i < 60
            {
                Console.WriteLine("Пожалуйста, проходи.");
            }
            else
            {
                Console.WriteLine("Извини, ты не можешь пройти. УХОДИ!");
            }
            return;
        }

        //7 Пример использования тернарного оператора.
        {
            Console.Write("Введи делимое: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введи делитель: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // делить на ноль нельзя, меняем на единицу
            int c = b == 0
                ? 1
                : a / b;
            Console.Write("Частное: " + c);
            return;
        }

        //8 Шаблон switch
        {
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("First case");
                    break;//ставится в конце каждого кейса обязательно
                case 2:
                case 3:
                    Console.WriteLine("Second case");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
                    //Делаем что то, если x не равен ни 1, ни 2, ни 3.
            }
            return;
        }

        // switch expression
        {
            Console.WriteLine("Введите число от 0 до 15: ");
            int a = Convert.ToInt32(Console.ReadLine());

            string b = a switch
            {
                > 0 and < 10 => Convert.ToString(a),
                10 => "A",
                11 => "B",
                12 => "C",
                13 => "D",
                14 => "E",
                15 => "F",
                _ => "Мы не умеем переводить такие числа"
            };
            Console.WriteLine (b);
        }