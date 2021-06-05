using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı  boş geçemezsiniz");
            RuleFor(x => x.Subject).MaximumLength(3).WithMessage("Lütfen 3 karakter fazla değer girişi yapmayın");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakter fazla değer girişi yapmayın");
            //  RuleFor(m => m.SenderMail).NotEmpty().WithMessage("Gönderen adı boş geçilmez.");


        }

    }
}
