using System;


public class Repositorio<T> where T : EntidadeBase
{
    protected readonly List<T> registros;
    protected int contID;

    public Repositorio()
    {
        registros = new List<T>();
    }

    public string Inserir(T registro)
    {
        string resultado = registro.Validar();
        if (resultado != "REGISTRO_VALIDO")
            return resultado;

        registro.id = ++contID;
        registros.Add(registro);
        return "REGISTRO_VALIDO";
    }
    
}
