//@BaseCode
using CommonBase.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Controllers
{
    internal abstract partial class ControllerObject : IDisposable
    {
        private bool contextOwner;
        protected Contracts.IContext Context { get; set; }
public ControllerObject(Contracts.IContext context )
        {
            context.CheckArgument(nameof(context));
            Context = context;
            contextOwner = true;
        }
        public ControllerObject(ControllerObject other)
        {
            other.CheckArgument(nameof(other));

            contextOwner = false;
            Context = other.Context;
        }

        #region Dispose pattern
        private bool disposedValue;

        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    if (contextOwner)
                    {
                        Context.Dispose();
                    }
                    Context = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~ControllerObject()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion Dispose pattern
    }
}
