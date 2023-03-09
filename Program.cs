 string[] s;
            Console.WriteLine("Введите массив строк через пробел:");
            string stroka = Console.ReadLine();
            s = stroka.Split(' ');
            var result = new string[s.Length];
            var realSize = 0;
            
            foreach (var value in s )
            {
                if (value.Length <= 3)
                
                    {
                    result[realSize] = value;
                    realSize++;
                    }
            }
            Console.WriteLine ($"Массив из строк, длина которых <= 3 символа: \n{string.Join(Environment.NewLine, result, 0, realSize)}");
            
            
