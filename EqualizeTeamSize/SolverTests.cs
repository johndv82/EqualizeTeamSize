using Xunit;

namespace EqualizeTeamSize
{
    public class SolverTests
    {
        [Fact]
        public void Test_Ejemplo1()
        {
            int[] teamSize = { 1, 2, 9, 7, 6, 6, 6 };
            int k = 2;

            var resultado = Solver.equalizeTeamSize(teamSize, k);

            Assert.Equal(new[] { 1, 2, 6, 6, 6, 6, 6 }, resultado);
        }

        [Fact]
        public void Test_Ejemplo2()
        {
            int[] teamSize = { 2, 5, 3, 3, 6, 7, 8 };
            int k = 2;

            var resultado = Solver.equalizeTeamSize(teamSize, k);

            Assert.Equal(new[] { 2, 5, 3, 3, 6, 3, 3 }, resultado);
        }

        [Fact]
        public void Test_Ejemplo3()
        {
            int[] teamSize = { 20, 20, 20, 4, 4, 1 };
            int k = 3;

            var resultado = Solver.equalizeTeamSize(teamSize, k);

            Assert.Equal(new[] { 4, 4, 4, 4, 4, 1 }, resultado);
        }

        [Fact]
        public void Test_KIgualCero_NoDebeReducir()
        {
            int[] teamSize = { 1, 2, 3, 4 };
            int k = 0;

            var resultado = Solver.equalizeTeamSize(teamSize, k);

            Assert.Equal(new[] { 1, 2, 3, 4 }, resultado);
        }

        [Fact]
        public void Test_KMayorQueReducibles()
        {
            int[] teamSize = { 1, 2, 5, 6 };
            int k = 10;

            var resultado = Solver.equalizeTeamSize(teamSize, k);

            Assert.Equal(new[] { 1, 1, 1, 1 }, resultado);
        }

        [Fact]
        public void Test_NumerosNegativosDebeFallar()
        {
            int[] teamSize = { 1, -2, 3 };
            int k = 1;

            Assert.Throws<ArgumentException>(() => Solver.equalizeTeamSize(teamSize, k));
        }

        [Fact]
        public void Test_KNegativoDebeFallar()
        {
            int[] teamSize = { 1, 2, 3 };
            int k = -1;

            Assert.Throws<ArgumentException>(() => Solver.equalizeTeamSize(teamSize, k));
        }
    }
}
