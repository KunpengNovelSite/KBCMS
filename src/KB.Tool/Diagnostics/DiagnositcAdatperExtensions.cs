using Microsoft.Extensions.DiagnosticAdapter;
using System.Diagnostics;

namespace KB.Tool.Diagnostics
{
    public static class DiagnositcAdatperExtensions
    {
        public static void AddToolkitDiagnositcs(this DiagnosticListener diagnosticListener)
        {
            diagnosticListener.SubscribeWithAdapter(new ExceptionHandlerDiagnostic());
        }
    }
}
