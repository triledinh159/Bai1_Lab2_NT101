using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;
using System.Diagnostics;

namespace Bai1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger randomLargeNumber = GenerateRandomLargeNumber();
            num1.Text = randomLargeNumber.ToString();
        }
        private BigInteger GenerateRandomLargeNumber()
        {
            Random random = new Random();
            byte[] bytes = new byte[32]; // 32 bytes = 256 bits
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F; // Ensure the most significant bit is 0 for a positive number
            return new BigInteger(bytes);
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger randomLargeNumber = GenerateRandomLargeNumber();
            num2.Text = randomLargeNumber.ToString();
        }

        private void gcd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigInteger num_gcd = calcGCD(BigInteger.Parse(num1.Text), BigInteger.Parse(num2.Text));
            gcd.Text = num_gcd.ToString();
        }
        private BigInteger calcGCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mod_res_TextChanged(object sender, EventArgs e)
        {
            

        }
        private BigInteger ModExp(BigInteger a, BigInteger x, BigInteger p)
        {
            BigInteger result = 1;
            a = a % p;

            while (x > 0)
            {
                if (x % 2 == 1)
                    result = (result * a) % p;

                x >>= 1; // Equivalent to x = x / 2
                a = (a * a) % p;
            }

            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BigInteger result = ModExp(BigInteger.Parse(num_a.Text), BigInteger.Parse(num_x.Text), BigInteger.Parse(num_p.Text));
            mod_res.Text = result.ToString();
        }
        private bool MillerRabinTest(BigInteger n, int k)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            for (int i = 0; i < k; i++)
            {
                BigInteger a = GenerateRandomBigInteger(2, n - 2);
                BigInteger x = ModExp(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = ModExp(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        private BigInteger GenerateRandomPrime()
        {
            BigInteger randomNum = GenerateRandomLargeNumber();
            while (!MillerRabinTest(randomNum, 5))
            {
                randomNum = GenerateRandomLargeNumber();
            }
            return randomNum;
        }

        private BigInteger GenerateRandomBigInteger(BigInteger minValue, BigInteger maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentException("minValue must be less than or equal to maxValue");
            }

            Random random = new Random();
            byte[] bytes = new byte[maxValue.ToByteArray().Length];
            BigInteger randomNum;

            do
            {
                random.NextBytes(bytes);
                randomNum = new BigInteger(bytes);
            } while (randomNum < minValue || randomNum > maxValue);

            return randomNum;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BigInteger randomPrime = GenerateRandomPrime();
            ran_pri.Text = randomPrime.ToString();
        }

        private void Benchmark()
        {
            const int iterations = 1000; // Number of iterations for each operation
            Stopwatch stopwatch = new Stopwatch();

            // Benchmark generating random large numbers
            long totalRandomNumTime = 0;
            for (int i = 0; i < iterations; i++)
            {
                stopwatch.Restart();
                BigInteger randomNum = GenerateRandomLargeNumber();
                stopwatch.Stop();
                totalRandomNumTime += stopwatch.ElapsedMilliseconds;
            }
            double avgRandomNumTime = totalRandomNumTime / (double)iterations;

            // Benchmark testing primality
            long totalPrimalityTestTime = 0;
            for (int i = 0; i < iterations; i++)
            {
                BigInteger randomPrime = GenerateRandomLargeNumber();
                stopwatch.Restart();
                bool isPrime = MillerRabinTest(randomPrime, 5);
                stopwatch.Stop();
                totalPrimalityTestTime += stopwatch.ElapsedMilliseconds;
            }
            double avgPrimalityTestTime = totalPrimalityTestTime / (double)iterations;

            // Benchmark modular exponentiation
            long totalModExpTime = 0;
            for (int i = 0; i < iterations; i++)
            {
                BigInteger randomA = GenerateRandomLargeNumber();
                BigInteger randomX = GenerateRandomLargeNumber();
                BigInteger randomP = GenerateRandomLargeNumber();
                stopwatch.Restart();
                BigInteger result = ModExp(randomA, randomX, randomP);
                stopwatch.Stop();
                totalModExpTime += stopwatch.ElapsedMilliseconds;
            }
            double avgModExpTime = totalModExpTime / (double)iterations;

            // Print the average times
            MessageBox.Show($"Average Random Number Generation Time: {avgRandomNumTime} ms");
            MessageBox.Show($"Average Primality Test Time: {avgPrimalityTestTime} ms");
            MessageBox.Show($"Average Modular Exponentiation Time: {avgModExpTime} ms");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Benchmark();
        }
    }
}
