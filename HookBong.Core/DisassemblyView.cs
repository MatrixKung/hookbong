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


        public static List<string> DisassembleToLines(Byte[] codeBytes, ulong RIP)
        {
            var disassOut = new List<string>();
            
            var codeReader = new ByteArrayCodeReader(codeBytes);
            var decoder = Decoder.Create(Environment.Is64BitProcess? 64 : 32, codeReader);
            decoder.IP = RIP;
            
            
            var formatter = new MasmFormatter();
            var output = new FormatterOutputImpl();

            foreach (var instr in decoder) {
                output.List.Clear();
                var outText = "";
                formatter.Format(instr, output);
                foreach (var (text, kind) in output.List) {
                    outText += (text);
                }
                disassOut.Add(outText);
            }

            return disassOut;
        }

        public static List<string> FormatBytes(Byte[] codeBytes, ulong RIP)
        {
            var decodeOut = new List<string>();
            
            var codeReader = new ByteArrayCodeReader(codeBytes);
            var decoder = Decoder.Create(Environment.Is64BitProcess? 64 : 32, codeReader);
            decoder.IP = RIP;
            var endRip = decoder.IP + (uint)codeBytes.Length;
            
            var instructions = new InstructionList();
            while (decoder.IP < endRip) {
                decoder.Decode(out instructions.AllocUninitializedElement());
            }

            var formatter = new NasmFormatter();

            formatter.Options.DigitSeparator = "`";
            formatter.Options.FirstOperandCharIndex = 10;

            var output = new StringOutput();

            foreach (ref var instr in instructions) {
                formatter.Format(instr, output);
                var outText = (instr.IP.ToString("X16"));
                outText += (" ");
                var instrLen = instr.Length;
                var byteBaseIndex = (int)(instr.IP - RIP);
                for (var i = 0; i < instrLen; i++)
                    outText += (codeBytes[byteBaseIndex + i].ToString("X2"));
                var missingBytes = 10 - instrLen;
                for (var i = 0; i < missingBytes; i++)
                    outText +=("  ");
                outText +=(" ");
                outText += (output.ToStringAndReset());
                decodeOut.Add(outText);
            }

            return decodeOut;
        }



    }
}