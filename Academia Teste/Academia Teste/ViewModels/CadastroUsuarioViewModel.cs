using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Academia_Teste.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage="Informe seu nome")]
        [MaxLength(100,ErrorMessage="O nome deve ter até 100 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe seu Login")]
        [MaxLength(50, ErrorMessage = "O Login deve ter até 50 caracteres")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe seu Senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelomenos 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]               
        [MinLength(6, ErrorMessage = "A senha deve ter pelomenos 6 caracteres")]
       public string ConfirmacaoSenha { get; set; }
    }
}