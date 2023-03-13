/*

2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.


IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/
int Fibo = 0;
int num1=1;
int num2=0;
List<int> ListaFibonacci = new List<int>();

int.TryParse(Console.ReadLine(), out int valor);
Console.WriteLine("Sequencia de Fibonacci");
while(Fibo<=valor){
    ListaFibonacci.Add(Fibo);
    Fibo=num1+num2;
    num2=num1;
    num1=Fibo;
    }

foreach(int i in ListaFibonacci){
    Console.WriteLine(i);
}

if(ListaFibonacci.Contains(valor)){
    Console.WriteLine("Numero informado pertence a sequnecia");
}else{
    Console.WriteLine("Numero informado não pertence a sequencia");
}
