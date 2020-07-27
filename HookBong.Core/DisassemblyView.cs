using System;
using System.Collections.Generic;
using Iced.Intel;

namespace HookBong.Core
{
    public static class DisassemblyView
    {

        sealed class FormatterOutputImpl : FormatterOutput {
            public readonly List<(string text, FormatterTextKind kind)> List =
                new List<(string text, FormatterTextKind kind)>();
            public override void Write(string text, FormatterTextKind kind) => List.Add((text, kind));
        }


        public static string[] DisassembleToLines(Byte[] codeBytes, ulong RIP)
        {
            var disassOut = new List<string>();
            
            var codeReader = new ByteArrayCodeReader(codeBytes);
            var decoder = Decoder.Create(Environment.Is64BitProcess? 64 : 32, codeReader);
            decoder.IP = RIP;
            
            
            var formatter = new MasmFormatter();
            var output = new FormatterOutputImpl();

            var outText = "";

            foreach (var instr in decoder) {
                output.List.Clear();
                outText = "";
                formatter.Format(instr, output);
                foreach (var (text, kind) in output.List) {
                    outText += (text);
                }
                disassOut.Add(outText);
            }

            return disassOut.ToArray();
        }
    }
}