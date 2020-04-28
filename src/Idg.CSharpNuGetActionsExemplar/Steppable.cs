using System;
using System.Text;

namespace Idg.CSharpNuGetActionsExemplar
{
    public static class Steppable
    {
        public static string Method(int input)
        {
            var sb = new StringBuilder();
            sb.AppendLine("This is a method with multiple lines of code.");
            sb.AppendLine("It's here so we can verify that our NuGet package symbols have been uploaded, and that the dev tools can find them and use them.");
            sb.AppendLine($"Your input was: {input}");

            return sb.ToString();
        }

        public static void Throw(string message)
        {
            // Throw so we can cause the debugger to break in, which can be handy when testing NuGet package symbol availability.
            throw new ArgumentException($"This isn't an argument!", nameof(message));
        }
    }
}