using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownDeep
{
    internal static class RenderTokens
    {
        internal const string ClassAttr = " class=\"{0}\"";
        internal const string CodeBlockStart = "<pre><code{0}>";
        internal const string CodeBlockEnd = "</code></pre>\n\n";

        internal const char NewLine = '\n';
        internal const char Carriage = '\r';
        internal const char Terminator = '\0';
    }
}
