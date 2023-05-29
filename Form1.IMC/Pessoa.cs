public class Pessoa
{

    private string nome;
    private string cpf;
    private double altura;
    private double peso;
    private string sexo;
    private int idade;

    public Pessoa(string nome, string cpf, double altura, double peso, string sexo, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.idade = idade;
    }

    public double GetAltura()
    {
        return this.altura;
    }

    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

    public double GetPeso()
    {
        return this.peso;
    }

    public void SetPeso(double  peso)
    {
        this.peso = peso;
    }

    public double GetIdade()
    {
        return this.idade;
    }

    public void SetIdade(int idade)
    {
        this.idade = idade;
    }

    public (double, string, string) CalcularIMC()
    {
        double calculo = this.peso / (this.altura * this.altura);


        if(calculo < 18.5)
        {
            return (calculo, "magreza", "0");
        }


        else if (calculo >= 18.5 && calculo <= 24.9)
        {
            string classificacao = "normal";
            string grau = "0";
            return (calculo, classificacao, grau);

        }

        else if(calculo >=25 && calculo <= 29.99)
        {
                string classificacao = "sobrepeso";
                string grau = "I";
                return (calculo, classificacao, grau);        
        }


        else if (calculo >= 30 && calculo <= 39.99)
        {
            string classificacao = "obesidade";
            string grau = "II";
            return (calculo, classificacao, grau);

        }


        else
        {
            string classificacao = "obesidade grave";
            string grau = "III";
            return (calculo, classificacao, grau);

        }

       
    }
   
}