using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable // the reason why this is the empty interface is to combine the two interfaces becuase unnessary type casting to get the both interface methods
    {
    }
}
