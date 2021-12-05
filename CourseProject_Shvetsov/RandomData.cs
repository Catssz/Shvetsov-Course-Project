using System;

namespace Taxopark
{
    /**
     * Статический класс, описывающий методы получения рандомных типов данных
     * 
     * Т.к. класс статический, необязательно создавать его экземпляр для обращения к его методам
     */
    public static class RandomData
    {
        /**
         * Метод получения рандомного целого числа
         * 
         * @param min - минимальное число
         * @param max - максимальное число (не включается в генерацию)
         */
        public static int GetInteger(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Метод получения рандомной строки, состоящей из букв, заданной длины и локализации (языка)
        public static string GetString(int length)
        {
            string result = "";

            // Посимвольная генерация строки
            for (int i = 0; i < length; i++)
            {
                /**
                 * Генерация рандомного числа и приведение его к типу char
                 * 
                 * Рандомное число лежит в диапазоне от 1040 до 1104 (невключая последнее), обозначая ASCII-код русской буквы
                 */
                Random random = new Random();
                result += (char)random.Next(1040, 1104);
            }

            return result;
        }
    }
}
