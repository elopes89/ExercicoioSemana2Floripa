namespace Semana1Floripa.Model;

public class ContaBancaria
{
    public int numero { get; set; }
    public int agencia { get; set; }

    public string nomeTitular { get; set; }
    public double saldo { get; set; } = 0d;

    public enum ETipoConta
    {
        CORRENTE,
        POUPANCA
    }

    public double Depositar(double deposito)
    {
        if (deposito > 0)
        {
            saldo += deposito;
        }
        return saldo;
    }

    public double Sacar(double saque)
    {
        if (saque > 0 & saque < saldo)
        {
            this.saldo -= saque;
        }
        return saldo;
    }

    public string ExibirSaldo()
    {
        return $"Saldo atual: {saldo}";
    }

}