using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.Interpolation;

namespace NIPI_projects
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
    class Solution
    {
        // Здесь сложность заключается в том, что мы пытаемся найти подходящие значения сразу в 2 функциях
        // Из-за этого приходится строить одну целевую функцию, содержащую в себе 2 нам необходимые, которую пришлось бы минимизировать
        // Можно было бы аналитически выразить целевую функцию через S_в и S_г, однако для вычисления показателей мы использовали интерполированные функции
        // Это сильно затрудняет вычисление производных

        // Градиентный спуск в нашем случае показывает не самые хорошие результаты. Поэтому было решено взять эвристический алгоритм на пробу

         /*
         * Сам алгоритм в идеале должен выглядеть следующим образом (если правильно было понято условие задания, конечно):
         * 1) инициализируем начальные данные (из таблиц и полей для ввода)
         * 2) интерполируем значения из таблицы и получаем непрерывные в необходимом интервале функции
         * 3) используем численную оптимизацию для того, чтобы получить удовлетворяющие целевым условиям показатели 
         *     - Пока не достигнется необходимый уровень разницы между целевыми и вычисленными показателями, либо максимальное количество итераций не будет достигнуто, 
         *       итеративно продолжать искать значения согласно алгоритму оптимизации
         * 4) возвращаем полученные значения
         */

         /* 
         Еще одной идеей для алгоритма был полный перебор всех табличных вариантов S_w и S_g с попыткой найти наиболее близкие к целевым показатели, 
         а потом уже с помощью интерполяции сделать функции непрерывными на том отрезке, где предположительно находится удовлетворяющие нас показатели.
         После этого уже данный диапазон рассмотреть для численной оптимизации. Однако, возможно, таблица сама будет огромной, и перебор будет занимать больше времени
         */

        // Тут также есть переменные, которые мы должны, по идее, вводить, однако в наших формулах для нахождения Q они сокращаются
        public double Delta_P { get; set; }
        public double J_D { get; set; }
        public double k { get; set; }
        public double h { get; set; }

        // Эти переменные не сокращаются и остаются в формулах
        public double mu_n { get; set; }
        public double mu_w { get; set; }
        public double mu_g { get; set; }
        public double B_n { get; set; }
        public double B_w { get; set; }
        public double B_g { get; set; }
        public double Rs { get; set; }

        // Наши функции, которые затем будут использоваться интерполированно
        private IInterpolation kr_w_sw_spline, kr_n_sw_spline, kr_g_sg_spline, kr_n_sg_spline;

        // Табличные данные
        double[] Sw_values,kr_nw_values, Sg_values, kr_ng_values, kr_w_sw, kr_n_sw, kr_g_sg, kr_n_sg;

        // Проверочные данные 
        public Solution() {
            Sw_values = new double[] { 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 1 };
            Sg_values = new double[] { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.8 };
            kr_w_sw = new double[] { 0, 0.012, 0.048, 0.108, 0.192, 0.3, 0.3 };
            kr_n_sw = new double[] { 1, 0.512, 0.288, 0.128, 0.032, 0, 0 };
            kr_g_sg = new double[] { 0, 0, 0.007812, 0.0625, 0.210938, 0.5, 1 };
            kr_n_sg = new double[] { 1, 0.8, 0.389711, 0.141421, 0.025, 0, 0 };

            // Не особо нужны
            Delta_P = 1;
            J_D = 2;
            k = 3;
            h = 2;

            mu_n = 9.8;
            mu_w = 1;
            mu_g = 0.0148;

            B_n = 1.09;
            B_w = 1;
            B_g = 0.0081;

            Rs = 45.9;
            Init_Interpolation();
        }

        // Конструктор, куда передадим наши табличные значения
        public Solution(double[] S_w, double[] OFP_water, double[] OFP_water_petroleum, double[] S_g, double[] OFP_gas, double[] OFP_gas_petroleum)
        {
            Sw_values = S_w;
            kr_w_sw = OFP_water;
            kr_n_sw = OFP_water_petroleum;
            Sg_values = S_g;
            kr_g_sg = OFP_gas;
            kr_n_sg = OFP_gas_petroleum;
            Init_Interpolation();
        }

        private void Init_Interpolation()
        {
            kr_w_sw_spline = CubicSpline.InterpolateNaturalSorted(Sw_values, kr_w_sw);
            kr_n_sw_spline = CubicSpline.InterpolateNaturalSorted(Sg_values, kr_n_sw);
            kr_g_sg_spline = CubicSpline.InterpolateNaturalSorted(Sw_values, kr_g_sg);
            kr_n_sg_spline = CubicSpline.InterpolateNaturalSorted(Sg_values, kr_n_sg);
        }

        // Не самый удачный способ, так как можно будет вызывать другие методы без задания этих параметров
        // Но хотелось конструктор сделать не с огромным количество параметров, поэтому туда только таблички передаются, которые впоследствии используются в интерполяции и вычислениях
        public void set_parameters(double deltaP, double JD, double k, double h, double muN, double muW, double muG, double BN, double BW, double BG, double Rs) 
        { 
            Delta_P = deltaP; 
            this.J_D = JD; 
            this.k = k; 
            this.h = h; 
            this.mu_n = muN; 
            this.mu_w = muW; 
            this.mu_g = muG; 
            this.B_n = BN; 
            this.B_w = BW; 
            this.B_g = BG; 
            this.Rs = Rs; 
        }


        public double kr_n_Sw_Sg(double S_w, double S_g)
        {

            double SWL = Sw_values.Min();
            return ((S_w - SWL) * kr_n_sw_spline.Interpolate(S_w + S_g) + S_g * kr_n_sg_spline.Interpolate(S_g + S_w - SWL)) / (S_g + S_w - SWL);
        }

        public double gas_factor(double S_w, double S_g)
        {
            // Q_г/Q_н. Используется не формула из презентации, а ее сокращенный вид (некоторые величины, например, Delta_P и в числителе, и в знаменателе)
            return (kr_g_sg_spline.Interpolate(S_g) * mu_n * B_n)/(kr_n_Sw_Sg(S_w, S_g) * mu_g * B_g) + Rs;
        }

        public double water_factor(double S_w, double S_g)
        {
            // Q_в / (Q_н + Q_в). Тоже используется сокращенный вид
            return kr_w_sw_spline.Interpolate(S_w)/(kr_n_Sw_Sg(S_w, S_g) + kr_w_sw_spline.Interpolate(S_w));
        }


        // Эти методы вычислений дебитов не используются в оптимизационных алгоритмах, но на всякий случай
        public double Q_n(double S_w, double S_g) 
        { 
            return Delta_P * J_D * (k * h / 18.18) * (kr_n_Sw_Sg(S_w, S_g) / (mu_n * B_n)); 
        }
        public double Q_w(double S_w) 
        { 
            return Delta_P * J_D * (k * h / 18.18) * (kr_w_sw_spline.Interpolate(S_w) / (mu_w * B_w)); 
        }
        public double Q_g(double S_g, double S_w) 
        { 
            double Q_oil = Q_n(S_w, S_g);
            return Delta_P * J_D * (k * h / 18.18) * kr_g_sg_spline.Interpolate(S_g) / (mu_g * B_g) + Rs * Q_oil; 
        }

        // Градиентный спуск (он работает гораздо хуже отжига, в самой форме мы его не вызываем)
        public (double S_w, double S_g) Grad_optimize(double target_W, double target_G)
        {
            if (target_W > 1)
            {
                target_W /= 100;
            }
            double epsilon = 1e-5;  // При какой разнице мы будем считать алгоритм нашедшим решение
            double S_w = 0.1, S_g = 0.2;  // Начальные значения
            double step_size = 0.1;  // Начальный размер шага
            int max_iter = 1000;  // Максимальное число итераций

            for (int iter = 0; iter < max_iter; iter++)
            {
                // Текущие значения обводнённости и газового фактора
                double curr_W = water_factor(S_w, S_g);
                double curr_G = gas_factor(S_w, S_g);

                // Велика ли разница между целевым и вычисленным показателями
                if (Math.Abs(curr_W - target_W) < epsilon && Math.Abs(curr_G - target_G) < epsilon)
                    // Если не велика, то алгоритм заканчивает свою работу
                    return (S_w, S_g);

                // Частные производные. Написаны через малые приращения 
                double grad_W_Sw = (water_factor(S_w + 1e-6, S_g) - curr_W) / 1e-6;
                double grad_W_Sg = (water_factor(S_w, S_g + 1e-6) - curr_W) / 1e-6;
                double grad_G_Sw = (gas_factor(S_w + 1e-6, S_g) - curr_G) / 1e-6;
                double grad_G_Sg = (gas_factor(S_w, S_g + 1e-6) - curr_G) / 1e-6;

                // Ошибка обводнённости и газового фактора
                double error_Sw = 2 * (curr_W - target_W) * grad_W_Sw +
                                      2 * (curr_G - target_G) * grad_G_Sw;
                double error_Sg = 2 * (curr_W - target_W) * grad_W_Sg +
                                      2 * (curr_G - target_G) * grad_G_Sg;

                // Обновляем S_w и S_g
                S_w -= step_size * error_Sw;
                S_g -= step_size * error_Sg;

                // Ограничения для S_w и S_g
                if (S_w < 0) S_w = 0.0;
                if (S_g < 0) S_g = 0.0;
                if (S_w + S_g > 1)
                {
                    double t = (S_w + S_g) - 1;
                    S_w -= t / 2;
                    S_g -= t / 2;
                }

                // Уменьшение шага при необходимости
                if (iter % 100 == 0)
                {
                    step_size *= 0.9;
                }
            }
            return (S_w, S_g);
        }

        // Алгоритм имитации отжига
        // В тестовых данных работает лучше градиентного спуска, но далеко не всегда выдает необходиые по условию результаты
        // Однако это - эвристический метод, и нет каких-либо методов гарантированного улучшения результатов
        public (double S_w, double S_g) SimulatedAnnealing(double target_W, double target_G)
        {
            // Если число введено в процентах, то превращаем проценты в коэффициент
            if (target_W > 1)
            {
                target_W /= 100;
            }
            Random rand = new Random();
            double T = 10000; // Начальная температура
            double cooling_rate = 0.99; // Коэффициент охлаждения
            double eps = 1e-5; // Допуск
            double S_w = 0.5, S_g = 0.5; // Начальные значения
            double best_S_w = S_w, best_S_g = S_g;
            double step = 0.1;
            double best_error = double.MaxValue;

            while (T > 1)
            {
                // Генерируем новое состояние
                double new_S_w = S_w + (rand.NextDouble() - 0.5) * step;
                double new_S_g = S_g + (rand.NextDouble() - 0.5) * step;

                // Ограничиваем значения
                if (new_S_w < 0) new_S_w = 0;
                if (new_S_g < 0) new_S_g = 0;
                if (new_S_w + new_S_g > 1)
                {
                    double excess = (new_S_w + new_S_g) - 1;
                    new_S_w -= excess / 2;
                    new_S_g -= excess / 2;
                }

                // Вычисляем текущую ошибку
                double currentWaterCut = water_factor(new_S_w, new_S_g);
                double currentGasFactor = gas_factor(new_S_w, new_S_g);
                double currentError = Math.Pow(currentWaterCut - target_W, 2) + Math.Pow(currentGasFactor - target_G, 2);

                // Если улучшение, принимаем новое состояние
                if (currentError <= best_error)
                {
                    best_error = currentError;
                    best_S_w = new_S_w;
                    best_S_g = new_S_g;
                }

                // Если состояние хуже, принимаем с вероятностью
                if (Math.Exp((best_error - currentError) / T) > rand.NextDouble())
                {
                    S_w = new_S_w;
                    S_g = new_S_g;
                }

                // Снижаем температуру
                T *= cooling_rate;

                // Проверяем сходимость 
                if (best_error < eps)
                    break;
            }

            return (best_S_w, best_S_g);
        }
    }
}
