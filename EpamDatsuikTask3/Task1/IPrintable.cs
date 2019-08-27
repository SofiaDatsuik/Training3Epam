using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamDatsuikTask3.Task1
{
    public interface IPrintable<T>
    {
        List<T> CreateList();

        List<T> AddItem();

    }
}
