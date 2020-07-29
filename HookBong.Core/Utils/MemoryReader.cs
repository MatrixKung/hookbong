using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace HookBong.Core.Utils
{
    public sealed class MemoryReader : IDisposable
    {
        private readonly IntPtr ProcessHandle;

        public MemoryReader(Process process)
        {
            ProcessHandle = NativeMethods.OpenProcess(ProcessAccessFlags.VirtualMemoryRead, false, process.Id);
            if (ProcessHandle == (IntPtr)(-1L))
                throw new AccessViolationException("Unable to create handle to process.");
        }

        public byte[] ReadMemory(IntPtr address, int size, out uint bytesRead)
        {
            var bytes = new byte[size];
            NativeMethods.ReadProcessMemory(ProcessHandle, address, bytes, (UIntPtr)size, out var read);
            bytesRead = (uint)read;
            return bytes;
        }

        public T ReadMemory<T>(IntPtr address)
        {
            var size = Marshal.SizeOf<T>();
            var read = ReadMemory(address, size, out var bytesRead);
            if (bytesRead != size)
                throw new AccessViolationException("Size read is not size of type.");
            unsafe
            {
                fixed (byte* bytes = read)
                    return Marshal.PtrToStructure<T>(new IntPtr(bytes));
            }
        }

        public void Dispose()
        {
            NativeMethods.CloseHandle(ProcessHandle);
        }
    }
}