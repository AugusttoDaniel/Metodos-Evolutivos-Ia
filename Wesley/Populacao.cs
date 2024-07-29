using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wesley
{
    internal class Populacao
    {
        /// <summary>
        /// Lista de Individuos que compoem a população atual 
        /// O melhor individuo da população
        /// O tamanho da população
        /// A chance que tem de um individuo sofrer mutação]
        /// random é um objeto da classe Random que é usado para gerar números aleatórios
        /// </summary>
        public List<Individuo> p { get; set; }
        public Individuo melhorIndiduo { get; set; }
        public int tamanhoPopulacao { get; set; }
        public double TaxaDeMutacao { get; set; }
        public static Random random = new Random();


        /// <summary>
        /// Construtor da classe Populacao.
        /// Inicializa a população com um tamanho específico, taxa de mutação, tamanho do bit, e os valores de a, b, c, min e max.
        /// </summary>
        /// <param name="tamanho">O tamanho da população a ser criada.</param>
        /// <param name="taxaDeMutacao">A taxa de mutação aplicada aos indivíduos.</param>
        /// <param name="tamBit">O tamanho do bit utilizado para representar cada indivíduo.</param>
        /// <param name="a">O valor do parâmetro 'a' utilizado na avaliação dos indivíduos.</param>
        /// <param name="b">O valor do parâmetro 'b' utilizado na avaliação dos indivíduos.</param>
        /// <param name="c">O valor do parâmetro 'c' utilizado na avaliação dos indivíduos.</param>
        /// <param name="min">O valor mínimo do intervalo de busca.</param>
        /// <param name="max">O valor máximo do intervalo de busca.</param>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Inicialização dos atributos da população:
        ///    - Atribui a taxa de mutação (`TaxaDeMutacao`) ao valor fornecido.
        ///    - Inicializa a lista de indivíduos (`p`) como uma nova lista vazia.
        ///    - Define o tamanho da população (`tamanhoPopulacao`) com o valor fornecido.
        ///
        /// 2. Criação dos indivíduos:
        ///    - Um loop é executado `tamanho` vezes, criando e adicionando um novo indivíduo à população a cada iteração.
        ///    - Cada indivíduo é instanciado com os parâmetros fornecidos: `tamBit`, `a`, `b`, `c`, `min`, `max`.
        ///
        /// 3. Atualização do melhor indivíduo:
        ///    - Após a criação de todos os indivíduos, o método `AtualizarMelhorIndividuo` é chamado para identificar e armazenar o melhor indivíduo da população na variável `melhorIndividuo`.
        /// </remarks>
        public Populacao(int tamanho, double taxaDeMutacao, int tamBit, double a, double b, double c, double min, double max)
        {
            TaxaDeMutacao = taxaDeMutacao;
            p = new List<Individuo>();
            tamanhoPopulacao = tamanho;

            for (int i = 0; i < tamanho; i++)
            {
                p.Add(new Individuo(tamBit, a, b, c, min, max));
            }

            AtualizarMelhorIndividuo();
        }

        /// <summary>
        /// Realiza a recombinação de dois pontos entre dois indivíduos, gerando dois novos indivíduos.
        /// </summary>
        /// <param name="x">O primeiro indivíduo pai utilizado na recombinação.</param>
        /// <param name="y">O segundo indivíduo pai utilizado na recombinação.</param>
        /// <returns>Uma lista contendo os dois novos indivíduos gerados pela recombinação.</returns>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Inicialização dos novos indivíduos:
        ///    - Cria dois novos indivíduos (`f1` e `f2`) com os mesmos parâmetros dos pais (`x` e `y`), como tamanho do bit, parâmetros `a`, `b`, `c`, `min` e `max`.
        /// 
        /// 2. Definição dos pontos de corte:
        ///    - Gera dois pontos de corte aleatórios. 
        ///      - `pontoDeCorte1` é um valor entre 1 e `x.tam - 1`.
        ///      - `pontoDeCorte2` é um valor entre `pontoDeCorte1 + 1` e `y.tam`.
        /// 
        /// 3. Recombinação dos bits dos indivíduos:
        ///    - Copia os bits dos pais para os filhos baseando-se nos pontos de corte:
        ///      - Para índices de 0 até `pontoDeCorte1 - 1`, os bits de `f1` são copiados de `x` e os bits de `f2` são copiados de `y`.
        ///      - Para índices de `pontoDeCorte1` até `pontoDeCorte2 - 1`, os bits de `f1` são copiados de `y` e os bits de `f2` são copiados de `x`.
        ///      - Para índices de `pontoDeCorte2` até o final, os bits de `f1` são copiados de `x` e os bits de `f2` são copiados de `y`.
        /// 
        /// 4. Atualização do estado dos novos indivíduos:
        ///    - Chama o método `UpdateState` para atualizar o estado de `f1` e `f2`, recalculando suas propriedades internas conforme necessário.
        /// 
        /// 5. Retorno dos novos indivíduos:
        ///    - Retorna uma lista contendo os dois novos indivíduos (`f1` e `f2`) gerados pela recombinação.
        /// </remarks>
        public List<Individuo> RecombinarDoisPontos(Individuo x, Individuo y)
        {
            Individuo f1 = new Individuo(x.tam, x.a, x.b, x.c, x.min, x.max);
            Individuo f2 = new Individuo(y.tam, y.a, y.b, y.c, y.min, y.max);

            int pontoDeCorte1 = random.Next(1, x.tam - 1);
            int pontoDeCorte2 = random.Next(pontoDeCorte1 + 1, y.tam);

            for (int i = 0; i < pontoDeCorte1; i++)
            {
                f1.bit[i] = x.bit[i];
                f2.bit[i] = y.bit[i];
            }

            for (int i = pontoDeCorte1; i < pontoDeCorte2; i++)
            {
                f1.bit[i] = y.bit[i];
                f2.bit[i] = x.bit[i];
            }

            for (int i = pontoDeCorte2; i < f1.tam; i++)
            {
                f1.bit[i] = x.bit[i];
                f2.bit[i] = y.bit[i];
            }

            f1.UpdateState();
            f2.UpdateState();

            return new List<Individuo> { f1, f2 };
        }

        /// <summary>
        /// Imprime e salva os detalhes da população em um arquivo de texto.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Tentativa de abertura do arquivo para escrita:
        ///    - Utiliza um bloco `try` para capturar qualquer exceção que possa ocorrer durante o processo de escrita no arquivo.
        ///    - Abre um `StreamWriter` para o arquivo "p.txt".
        ///
        /// 2. Iteração sobre cada indivíduo da população:
        ///    - Para cada indivíduo na lista `p`, o método `ToString` do indivíduo é chamado para obter seus detalhes.
        ///    - Os detalhes do indivíduo são impressos no console e escritos no arquivo.
        ///
        /// 3. Finalização da escrita:
        ///    - Após iterar sobre todos os indivíduos, o `StreamWriter` é fechado automaticamente devido ao uso do bloco `using`.
        ///    - Uma mensagem de sucesso é exibida no console indicando que a população foi salva com sucesso.
        ///
        /// 4. Tratamento de exceções:
        ///    - Caso ocorra uma exceção durante o processo de escrita no arquivo, uma mensagem de erro é exibida no console com os detalhes da exceção.
        /// </remarks>
        public void ImprimirESalvarPopulacao()
        {
            try
            {
                using (StreamWriter file = new StreamWriter("p.txt"))
                {
                    foreach (Individuo individuo in p)
                    {
                        string detalhes = individuo.ToString();
                        Console.WriteLine(detalhes);  
                        file.WriteLine(detalhes);    
                    }
                }
                Console.WriteLine("População salva com sucesso em p.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar a população: " + ex.Message);
            }
        }

        /// <summary>
        /// Aplica mutação aos indivíduos da população com base na taxa de mutação.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Inicialização do contador de mutações:
        ///    - Um contador `mutatedCount` é inicializado para rastrear o número de mutações que ocorrem.
        ///
        /// 2. Iteração sobre cada indivíduo da população:
        ///    - O método percorre todos os indivíduos da população `p`.
        ///
        /// 3. Verificação da condição de mutação:
        ///    - Para cada indivíduo, é gerado um número aleatório. Se esse número for menor que a taxa de mutação (`TaxaDeMutacao` convertida de porcentagem para decimal), a mutação ocorre.
        ///
        /// 4. Criação de um novo indivíduo mutado:
        ///    - Um novo indivíduo `mutated` é criado com os mesmos parâmetros do indivíduo original.
        ///    - Os valores do indivíduo original são copiados para o novo indivíduo usando o método `Copia`.
        ///    - O método `Mutar` é chamado no novo indivíduo para aplicar a mutação.
        ///
        /// 5. Substituição do indivíduo original pelo mutado:
        ///    - Se a adaptabilidade do indivíduo mutado for melhor (menor) do que a do original, o original é substituído pelo mutado.
        ///    - O contador `mutatedCount` é incrementado a cada mutação que ocorre.
        ///
        /// 6. Atualização do melhor indivíduo da população:
        ///    - Após todas as mutações, o método `AtualizarMelhorIndividuo` é chamado para atualizar o melhor indivíduo da população.
        ///
        /// 7. Exibição do número de mutações:
        ///    - O número total de indivíduos mutados nesta geração é exibido no console.
        /// </remarks>
        public void Multacao()
        {
            int mutatedCount = 0;  // Contador para indivíduos mutados
            foreach (Individuo individuo in p)
            {
                // Convertendo a taxa de mutação de porcentagem para valor decimal
                if (Individuo.random.NextDouble() < TaxaDeMutacao / 100.0)
                {
                    // Criar um novo indivíduo mutado com os mesmos parâmetros do original
                    Individuo mutated = new Individuo(individuo.tam, individuo.a, individuo.b, individuo.c, individuo.min, individuo.max);
                    mutated.Copia(individuo);
                    mutated.Mutar();

                    // Substituir o indivíduo original se a adaptabilidade do mutado for melhor (menor)
                    if (mutated.adaptabilidade < individuo.adaptabilidade)
                    {
                        individuo.Copia(mutated);
                    }
                    mutatedCount++;  // Incrementa o contador quando ocorre uma mutação
                }
            }
            AtualizarMelhorIndividuo();
            Console.WriteLine($"{mutatedCount} indivíduos foram mutados nesta geração.");
        }


        /// <summary>
        /// Realiza a seleção de um indivíduo da população utilizando o método da roleta.
        /// </summary>
        /// <returns>O indivíduo selecionado com base na probabilidade proporcional à sua adaptabilidade.</returns>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Cálculo do total de fitness:
        ///    - Calcula o somatório do inverso da adaptabilidade ajustada (1 / (1 + adaptabilidade)) para todos os indivíduos da população.
        ///    - Isso assegura que indivíduos com menor adaptabilidade (melhor fitness) têm maior probabilidade de serem selecionados.
        ///    - Sendo assim faz a minimização do problema
        ///
        /// 2. Geração de um valor aleatório:
        ///    - Gera um valor aleatório (`slice`) que varia de 0 até o total de fitness calculado.
        ///
        /// 3. Seleção do indivíduo:
        ///    - Itera sobre cada indivíduo na população, acumulando a soma parcial de fitness ajustada.
        ///    - Quando a soma parcial atinge ou excede o valor aleatório gerado (`slice`), o indivíduo corrente é selecionado e retornado.
        ///
        /// 4. Retorno:
        ///    - Se nenhum indivíduo for selecionado durante a iteração (o que é improvável), o método retorna null.
        /// </remarks>
        public Individuo SelecaoPorRoleta()
        {
            double totalFitness = p.Sum(individuo => 1 / (1 + individuo.adaptabilidade));
            double slice = random.NextDouble() * totalFitness;
            double partialSum = 0;

            foreach (var individuo in p)
            {
                partialSum += 1 / (1 + individuo.adaptabilidade);
                if (partialSum >= slice)
                {
                    return individuo;
                }
            }

            return null;
        }


        /// <summary>
        /// Atualiza o melhor indivíduo da população.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Ordenação da população por adaptabilidade:
        ///    - A população (`p`) é ordenada em ordem crescente de adaptabilidade. Indivíduos com menor adaptabilidade são considerados melhores.
        ///
        /// 2. Seleção do melhor indivíduo:
        ///    - O primeiro indivíduo da população ordenada é selecionado como o melhor indivíduo, pois ele tem a menor adaptabilidade.
        ///
        /// 3. Atualização da variável melhorIndividuo:
        ///    - A variável `melhorIndividuo` é atualizada para referenciar este melhor indivíduo.
        /// </remarks>
        public void AtualizarMelhorIndividuo()
        {
            this.melhorIndiduo = p.OrderBy(individuo => individuo.adaptabilidade).First();
        }
    }
}
