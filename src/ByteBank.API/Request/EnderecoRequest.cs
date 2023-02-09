using System.ComponentModel.DataAnnotations;

namespace ByteBank.API.Request;

public class EnderecoRequest
{
    [Required(ErrorMessage = "O campo logradouro é obrigatório")]
    [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
    required public string Logradouro { get; set; }

    [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
    public string? Complemento { get; set; }

    [Required(ErrorMessage = "O campo número é obrigatório")]
    required public int Numero { get; set; }

    [Required(ErrorMessage = "O campo CEP é obrigatório")]
    [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato 00000-000")]
    required public string Cep { get; set; }

}