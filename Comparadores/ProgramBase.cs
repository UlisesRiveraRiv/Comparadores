using System.Diagnostics;

namespace Comparadores
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal abstract class ProgramBase
    {
        private abstract string GetDebuggerDisplay();
    }
}