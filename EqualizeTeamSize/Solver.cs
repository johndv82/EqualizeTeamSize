
namespace EqualizeTeamSize
{
    static class Solver
    {
        public static int[] equalizeTeamSize(int[] teamSize, int k) {
            if (k < 0) {
                throw new ArgumentException("Número máximo de equipos no puede ser negativo");
            }

            if (teamSize.Any(x => x < 0))
                throw new ArgumentException("El tamaño de un equipo no puede ser negativo");

            var valoresUnicos = teamSize.Distinct().ToList();
            valoresUnicos.Sort();

            int mejorTarget = teamSize[0];
            int mejorCantidad = 0;

            //Mejor target
            foreach (int target in valoresUnicos)
            {
                int iguales = teamSize.Count(x => x == target);
                var reducibles = teamSize.Where(x => x > target).OrderBy(x => x).ToList();
                int usados = Math.Min(k, reducibles.Count);

                int total = iguales + usados;
                if (total > mejorCantidad)
                {
                    mejorCantidad = total;
                    mejorTarget = target;
                }
            }

            //Contruir resultado
            var resultado = new List<int>(teamSize);
            int reducidos = 0;

            for (int i = 0; i < resultado.Count && reducidos < k; i++)
            {
                if (resultado[i] > mejorTarget)
                {
                    resultado[i] = mejorTarget;
                    reducidos++;
                }
            }

            return resultado.ToArray();
        }
    }
}
