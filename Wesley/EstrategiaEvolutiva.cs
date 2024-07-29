using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wesley
{
    internal class EstrategiaEvolutiva
    {
        List<Individuo> populacao;
        int tamanhoPopulacao;
        int numeroGeracoes;
        double taxaMutacao;
        double taxaRecombinacao;
        private static Random random = new Random(); // Instância de Random

        public EstrategiaEvolutiva(int tamanho, int geracoes, double mutacao, double recombinacao)
        {
            tamanhoPopulacao = tamanho;
            numeroGeracoes = geracoes;
            taxaMutacao = mutacao;
            taxaRecombinacao = recombinacao;
            InicializarPopulacao();
        }

        private void InicializarPopulacao()
        {
            populacao = new List<Individuo>();
            for (int i = 0; i < tamanhoPopulacao; i++)
            {
                // Supondo que o tamanho do cromossomo é passado aqui
                //populacao.Add(new Individuo(10)); // Assumindo um tamanho de cromossomo de 10
            }
        }

        public void Executar()
        {
            for (int g = 0; g < numeroGeracoes; g++)
            {
                List<Individuo> novosIndividuos = SelecionarERecombinar();
                Mutar(novosIndividuos);
                populacao = SelecionarSobreviventes(populacao, novosIndividuos);
                if (CriterioDeParadaAlcancado())
                    break;
            }
        }

        private List<Individuo> SelecionarERecombinar()
        {
            List<Individuo> novosIndividuos = new List<Individuo>();
            while (novosIndividuos.Count < tamanhoPopulacao)
            {
                Individuo pai1 = populacao[random.Next(populacao.Count)];
                Individuo pai2 = populacao[random.Next(populacao.Count)];
                // Simples crossover de um ponto
                int pontoCorte = random.Next(1, pai1.tam);
                int[] novoBitArray = new int[pai1.tam];
                Array.Copy(pai1.bit, novoBitArray, pontoCorte);
                Array.Copy(pai2.bit, 0, novoBitArray, pontoCorte, pai1.tam - pontoCorte);
               // novosIndividuos.Add(new Individuo(novoBitArray)); // Assume um construtor que aceita bit array
            }
            return novosIndividuos;
        }

        private void Mutar(List<Individuo> individuos)
        {
            foreach (var individuo in individuos)
            {
                for (int i = 0; i < individuo.tam; i++)
            
                {
                    if (random.NextDouble() < taxaMutacao)
                        individuo.bit[i] = 1 - individuo.bit[i];
                }
            }
        }

        private List<Individuo> SelecionarSobreviventes(List<Individuo> antigos, List<Individuo> novos)
        {
            antigos.AddRange(novos);
            return antigos.OrderByDescending(x => x.adaptabilidade).Take(tamanhoPopulacao).ToList();
        }

        private bool CriterioDeParadaAlcancado()
        {
            return false;
        }
    }
}
