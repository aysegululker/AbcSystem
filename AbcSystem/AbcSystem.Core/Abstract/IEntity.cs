using AbcSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSystem.Core.Abstract
{
    public interface IEntity
    {
        Status Status { get; set; }

        //CreatedBy
        DateTime CreatedDate { get; set; }
        string CreatedComputerName { get; set; }
        string CreatedIP { get; set; }
        string CreatedAdUserName { get; set; }
        string CreatedBy { get; set; }


        //ModifiedBy
        DateTime ModifiedDate { get; set; }
        string ModifiedComputerName { get; set; }
        string ModifiedIP { get; set; }
        string ModifiedAdUserName { get; set; }
        string ModifiedBy { get; set; }
    }
}
