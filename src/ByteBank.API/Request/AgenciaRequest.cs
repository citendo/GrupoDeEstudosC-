using System.ComponentModel.DataAnnotations;

namespace ByteBank.API.Request;
public class AgenciaRequest
{
    required public int NumeroAgencia { get; set; }

    required public string NomeAgencia { get; set; }

    required public EnderecoRequest Endereco { get; set; }
}