using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Askmentor.DataEntity.Sample;

namespace Askmentor.Core.Repository
{
   public interface ISampleRepository
    {
     public string read(Sample name);
    }
}
