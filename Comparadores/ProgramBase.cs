using System.Diagnostics;

namespace Comparadores
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal abstract class ProgramBase
    {
        public abstract string GetDebuggerDisplay();
    }
}