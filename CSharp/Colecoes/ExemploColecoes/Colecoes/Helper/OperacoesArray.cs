namespace Colecoes.Helper

{
    public class OperacoesArray
    {
        int temp = 0;
        public void ordenarBubbleSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {   
            //for (int i = 0; i < array.Length; i++)   
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
            
        }
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }
    }
}