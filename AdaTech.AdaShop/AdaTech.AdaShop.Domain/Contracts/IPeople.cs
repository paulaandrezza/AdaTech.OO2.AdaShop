using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Contracts
{
    public interface IPeople
    {
        string Name { get; }
        string CPF { get; }
        string Email { get; }
        string PhoneNumber { get; }
    }
}
