using System.Security.Cryptography;

int anosAutonomia = 450;
double capacidadeBateria = 75.5;
string modeloVeiculo = "Byd";
bool carregamentoRapido = true;

Console.WriteLine($"Veiculo: {modeloVeiculo}");
Console.WriteLine($"Autonomia:{anosAutonomia} km | Bateria: {capacidadeBateria}");
Console.WriteLine($"Possui Carregamento Rapido: {carregamentoRapido}");

//preciso que faça o calculo para saber quando vou pagar de imposto do carro
const double Juros = 0.10; //10%
double precoVeiculo = 20000.00;

double valorImposto = precoVeiculo * Juros;
Console.WriteLine($"O valor do Imposto é R$: {valorImposto:N2}");

