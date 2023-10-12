using Descriminant_procent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Pract2_Collection
{
    [TestClass]
    public class Descriminanit_procent_Tests
    {


        static List<Tuple<double, double, double, List<double>>>Tests; //a, b, c и ожидаемые корни

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Tests = new List<Tuple<double, double, double, List<double>>>
            {
                new Tuple<double, double, double, List<double>>(1, 4, 3, new List<double> { -1, -3 }), // 2 корня
                new Tuple<double, double, double, List<double>>(1, -6, 9, new List<double> { 3 }),    // 1 корень
                new Tuple<double, double, double, List<double>>(5, 2, 5, new List<double> { }),     // НЕТ КОРНЕЙ!!!
            };
        }

        [TestMethod]
        public void PositiveDiscriminant()
        {
            var testCase = Tests[0];
            double a = testCase.Item1;
            double b = testCase.Item2;
            double c = testCase.Item3;
            List<double> expected = testCase.Item4;
            Descriminanit_procent sd = new Descriminanit_procent();
            List<double> result = sd.Discriminant_Solver(a, b, c);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZeroDiscriminant()
        {
            var testCase = Tests[1];
            double a = testCase.Item1;
            double b = testCase.Item2;
            double c = testCase.Item3;
            List<double> expected = testCase.Item4;
            Descriminanit_procent sd = new Descriminanit_procent();
            List<double> result = sd.Discriminant_Solver(a, b, c);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Discriminant_Solver_retuned()
        {
            var selected_test = Tests[2];
            double a = selected_test.Item1;
            double b = selected_test.Item2;
            double c = selected_test.Item3;
            List<double> expected = selected_test.Item4;
            Descriminanit_procent sd = new Descriminanit_procent();
            List<double> result = sd.Discriminant_Solver(a, b, c);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SearchProcient_retuned100()
        {
            // Тест с дельтой равной 0.01
            double number = 500.0f;
            double percentage = 0.0f;
            double expected = 0.0f;
            double delta = 0.001f;

            Descriminanit_procent sd = new Descriminanit_procent();
            double result = sd.SearchProcient(number, percentage);

            Assert.AreEqual(expected, result, delta, $"Сравниваем число {result} с числом {expected}, где погрешность = {delta}");
        }
    }
}
