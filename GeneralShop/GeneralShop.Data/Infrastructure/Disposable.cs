using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Infrastructure
{
    class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            { DisposeCore(); }

            isDisposed = true;   ;
        }

        protected virtual void DisposeCore()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
