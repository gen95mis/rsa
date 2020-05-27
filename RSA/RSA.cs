using System;

namespace Сipher
{
    class RSA
    {
        private long num;
        private long mod;
        private long pow;

        private int deltaX;
        private int deltaY;


        /// <summary>
        /// Разница между num и num2
        /// </summary>
        public int DeltaX
        {
            get { return deltaX; }
            set { deltaX = value; }
        }


        /// <summary>
        /// Разница между num1 и num2+deltaX
        /// </summary>
        public int DeltaY
        {
            get {
                long num2 = num + Convert.ToInt64(deltaX);
                deltaY = Convert.ToInt32(ModExp() + ModExp(num2));

                return deltaY;
            }
        }


        /// <param name="num">Число</param>
        /// <param name="pow">Степпень</param>
        /// <param name="mod">Модуль</param>
        public RSA(long num, long pow, long mod)
        {
            this.num = num;
            this.mod = mod;
            this.pow = pow;

            deltaX = 1;
        }


        /// <summary>
        /// Возведение в степень по модулю 
        /// </summary>
        /// <returns></returns>
        private long ModExp() => ModExp(num);


        /// <summary>
        /// Возведение в степень по модулю 
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Модуль от число в степени</returns>
        private long ModExp(long num)
        {
            long d = 1;
            long t = num;

            string binPow = Convert.ToString(pow, 2);

            for (int i = binPow.Length - 1; i >= 0; i--)
            {
                if (binPow[i] == '1')
                    d = (d * t) % mod;
                t = (t * t) % mod;
            }

            return t;
        }


        /// <summary>
        /// Шифрование RSA
        /// </summary>
        /// <returns>Зашифрованоое число</returns>
        public long RSASipher() => ModExp(num);
    }
}
