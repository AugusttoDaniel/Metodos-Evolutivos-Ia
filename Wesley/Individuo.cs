using System;
using System.Collections.Generic;
using System.Linq;

namespace Wesley
{
    internal class Individuo
    {
        public int[] bit { get; private set; }
        public int tam { get; private set; }
        public double fenotipo { get; private set; }
        public double x { get; private set; }
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }
        public double min { get; private set; }
        public double max { get; private set; }
        public double adaptabilidade { get; private set; }
        public static Random random = new Random();

        /// <summary>
        /// Construtor da classe Individuo.
        /// Inicializa um indivíduo com o tamanho do bit, parâmetros da função de adaptabilidade, e valores mínimo e máximo.
        /// </summary>
        /// <param name="tam">O tamanho do array de bits utilizado para representar o indivíduo.</param>
        /// <param name="a">O valor do parâmetro 'a' utilizado na função de adaptabilidade.</param>
        /// <param name="b">O valor do parâmetro 'b' utilizado na função de adaptabilidade.</param>
        /// <param name="c">O valor do parâmetro 'c' utilizado na função de adaptabilidade.</param>
        /// <param name="min">O valor mínimo do intervalo de busca para o fenótipo.</param>
        /// <param name="max">O valor máximo do intervalo de busca para o fenótipo.</param>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Inicialização dos atributos do indivíduo:
        ///    - Atribui os parâmetros `tam`, `a`, `b`, `c`, `min`, e `max` aos campos correspondentes da classe.
        ///    - Inicializa o array de bits (`BitArray`) com o tamanho fornecido (`tam`).
        ///
        /// 2. Inicialização do array de bits:
        ///    - Chama o método `InicializarBitArray` para preencher o array de bits com valores aleatórios (0 ou 1).
        ///
        /// 3. Atualização do estado do indivíduo:
        ///    - Chama o método `UpdateState` para calcular o fenótipo, valor de X, e a adaptabilidade do indivíduo com base nos valores iniciais.
        /// </remarks>
        public Individuo(int Tam, double A, double B, double C, double Min, double Max)
        {
            tam = Tam;
            a = A;
            b = B;
            c = C;
            min = Min;
            max = Max;
            bit = new int[Tam];
            InicializarBitArray();
            UpdateState();
        }

        /// <summary>
        /// Inicializa o array de bits com valores aleatórios (0 ou 1).
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Iteração sobre o array de bits:
        ///    - Um loop é executado para percorrer cada posição do array de bits (`bit`).
        ///
        /// 2. Geração de valores aleatórios:
        ///    - Para cada posição do array, um valor aleatório (0 ou 1) é gerado usando o método `random.Next(0, 2)`.
        ///    - O valor gerado é atribuído à posição correspondente no array de bits.
        /// </remarks>
        private void InicializarBitArray()
        {
            for (int i = 0; i < tam; i++)
            {
                bit[i] = random.Next(0, 2);
            }
        }

        /// <summary>
        /// Converte o array de bits para um valor decimal e armazena no fenótipo.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Inicialização do resultado:
        ///    - Inicializa uma variável `result` com o valor 0 para acumular o valor decimal resultante da conversão.
        ///
        /// 2. Iteração sobre o array de bits:
        ///    - Percorre cada posição do array de bits (`BitArray`).
        ///
        /// 3. Cálculo do valor decimal:
        ///    - Para cada bit no array, multiplica o valor do bit (0 ou 1) pela potência de 2 correspondente à sua posição.
        ///    - A potência de 2 é calculada como `Math.Pow(2, Tam - i - 1)`, onde `i` é o índice do bit no array.
        ///    - O resultado da multiplicação é adicionado ao acumulador `result`.
        ///
        /// 4. Armazenamento do fenótipo:
        ///    - Após completar a iteração sobre o array de bits, o valor acumulado em `result` é atribuído ao campo `Fenotipo`.
        /// </remarks>
        private void ConverterDecimal()
        {
            double result = 0;
            for (int i = 0; i < tam; i++)
            {
                result += bit[i] * Math.Pow(2, tam - i - 1);
            }
            fenotipo = result;
        }

        /// <summary>
        /// Calcula o valor de X com base no fenótipo e nos limites mínimo e máximo.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Determinação do intervalo:
        ///    - Calcula a diferença entre o valor máximo (`max`) e o valor mínimo (`min`).
        ///
        /// 2. Normalização do fenótipo:
        ///    - Divide o valor do fenótipo pelo valor máximo possível que o fenótipo pode ter, que é `Math.Pow(2, Tam) - 1`.
        ///
        /// 3. Cálculo do valor de X:
        ///    - Multiplica a diferença calculada no passo 1 pelo valor normalizado do fenótipo.
        ///    - Adiciona o valor mínimo (`min`) ao resultado para ajustar o valor de X ao intervalo desejado.
        ///    - Armazena o resultado no campo `X`.
        /// </remarks>
        private void CalcularValorDeX()
        {
            x = min + (max - min) * (fenotipo / (Math.Pow(2, tam) - 1));
        }

        /// <summary>
        /// Calcula a adaptabilidade do indivíduo usando a função quadrática.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Cálculo do termo quadrático:
        ///    - Multiplica o coeficiente `a` pelo quadrado do valor de `X` (ou seja, `X * X`).
        ///
        /// 2. Cálculo do termo linear e constante:
        ///    - Multiplica o coeficiente `b` pelo valor de `X`.
        ///    - Adiciona o coeficiente constante `c`.
        ///
        /// 3. Soma dos termos:
        ///    - Soma o resultado do termo quadrático com o resultado do termo linear e constante.
        ///    - Armazena o resultado na propriedade `Adaptabilidade`.
        /// </remarks>
        private void CalcularFitness()
        {
            adaptabilidade = (a * (x * x)) + (b * x + c);
        }

        /// <summary>
        /// Aplica mutação a um bit aleatório no array de bits.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Geração de índice aleatório:
        ///    - Gera um índice aleatório (`indexToMutate`) no intervalo de 0 a `tam` (exclusivo) usando `random.Next(tam)`.
        ///
        /// 2. Inversão do valor do bit:
        ///    - Acessa o bit no índice gerado e inverte o seu valor (se for 0, torna-se 1; se for 1, torna-se 0).
        ///
        /// 3. Atualização do estado do indivíduo:
        ///    - Chama o método `UpdateState` para recalcular o fenótipo, valor de X, e adaptabilidade do indivíduo com base no novo array de bits.
        /// </remarks>
        public void Mutar()
        {
            int indexToMutate = random.Next(tam); // Gera um índice aleatório para mutação (inclusivo para 0 e exclusivo para Tam)
            bit[indexToMutate] = 1 - bit[indexToMutate]; // Inverte o valor do bit
            UpdateState(); // Atualiza o estado do indivíduo após a mutação
        }

        /// <summary>
        /// Imprime os detalhes do indivíduo.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine(ToString());
        }

        /// <summary>
        /// Atualiza o estado do indivíduo, recalculando fenótipo, valor de X e adaptabilidade.
        /// </summary>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Conversão do array de bits para decimal:
        ///    - Chama o método `ConverterDecimal` para recalcular o valor do fenótipo a partir do array de bits.
        ///
        /// 2. Cálculo do valor de X:
        ///    - Chama o método `CalcularValorDeX` para recalcular o valor de X com base no novo fenótipo e nos limites mínimo e máximo.
        ///
        /// 3. Cálculo da adaptabilidade:
        ///    - Chama o método `CalcularFitness` para recalcular a adaptabilidade do indivíduo com base no novo valor de X e nos parâmetros da função quadrática.
        /// </remarks>
        public void UpdateState()
        {
            ConverterDecimal();
            CalcularValorDeX();
            CalcularFitness();
        }

        /// <summary>
        /// Copia os valores de outro indivíduo para este indivíduo.
        /// </summary>
        /// <param name="individuo">O indivíduo a ser copiado.</param>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Copia do array de bits:
        ///    - Inicializa um novo array de bits com o mesmo tamanho do array de bits do indivíduo fornecido.
        ///    - Usa `Array.Copy` para copiar os valores do array de bits do indivíduo fornecido para o novo array de bits.
        ///
        /// 2. Copia dos atributos do indivíduo:
        ///    - Copia o valor do tamanho (`tam`) do indivíduo fornecido.
        ///    - Copia o valor do fenótipo (`fenotipo`) do indivíduo fornecido.
        ///    - Copia o valor de X (`x`) do indivíduo fornecido.
        ///    - Copia os valores dos parâmetros `a`, `b`, `c` do indivíduo fornecido.
        ///    - Copia os valores mínimo (`min`) e máximo (`max`) do indivíduo fornecido.
        ///    - Copia o valor da adaptabilidade (`adaptabilidade`) do indivíduo fornecido.
        /// </remarks>
        public void Copia(Individuo individuo)
        {
            bit = new int[individuo.bit.Length];
            Array.Copy(individuo.bit, bit, individuo.bit.Length);

            tam = individuo.tam;
            fenotipo = individuo.fenotipo;
            x = individuo.x;
            a = individuo.a;
            b = individuo.b;
            c = individuo.c;
            min = individuo.min;
            max = individuo.max;
            adaptabilidade = individuo.adaptabilidade;
        }

        /// <summary>
        /// Retorna uma string que representa o indivíduo.
        /// </summary>
        /// <returns>Uma string com os detalhes do indivíduo.</returns>
        /// <remarks>
        /// Passo a passo do método:
        /// 1. Criação da representação do array de bits:
        ///    - Usa `string.Join` para criar uma string que representa o array de bits, com cada bit separado por um espaço.
        ///
        /// 2. Formatação dos detalhes do indivíduo:
        ///    - Constrói uma string que inclui:
        ///      - A representação do array de bits.
        ///      - O valor do fenótipo (`Fenotipo`).
        ///      - O valor de X (`X`).
        ///      - O valor da adaptabilidade (`Adaptabilidade`).
        ///
        /// 3. Retorno da string formatada:
        ///    - Retorna a string que contém todos os detalhes formatados do indivíduo.
        /// </remarks>
        public override string ToString()
        {
            return $"Bit Array: {string.Join(" ", bit)}\nFenotipo: {fenotipo}\nValor de X: {x}\nAdaptabilidade: {adaptabilidade}\n";
        }
    }
}
