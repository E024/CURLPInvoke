using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESTest
{
    public class SafeCurlHandle : IDisposable
    {
        private readonly IntPtr handle;

        public SafeCurlHandle(IntPtr handle)
        {
            this.handle = handle;
        }

        public IntPtr GetUnsafeHandle() => handle;

        public void Dispose()
        {
        }
    }
}
