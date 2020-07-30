using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace HookBong.Core.Utils
{
	public sealed class MemoryWriter : IDisposable
	{
		private readonly IntPtr ProcessHandle;

		public MemoryWriter(Process process)
		{
			ProcessHandle = NativeMethods.OpenProcess(ProcessAccessFlags.VirtualMemoryOperation | ProcessAccessFlags.VirtualMemoryWrite, false, process.Id);
			if (ProcessHandle == (IntPtr)(-1L))
				throw new AccessViolationException("Unable to create handle to process.");
		}

		public bool WriteMemory(IntPtr address, byte[] bytes, out uint bytesWritten)
		{
			bytesWritten = 0;
			if (bytes == null || bytes.Length == 0)
				return false;

			UIntPtr size = (UIntPtr)(Marshal.SizeOf(bytes[0]) * bytes.Length);
			bool success = NativeMethods.WriteProcessMemory(ProcessHandle, address, bytes, size, out var written);
			bytesWritten = (uint)written;
			return success;
		}

		public bool ProtectMemory(IntPtr address, int size, PageProtection newProtection, out PageProtection oldProtection)
		{
			bool success = NativeMethods.VirtualProtectEx(ProcessHandle, address, (UIntPtr)size, newProtection, out var oldProtect);
			oldProtection = (PageProtection)oldProtect;
			return success;
		}

		public void Dispose()
		{
			NativeMethods.CloseHandle(ProcessHandle);
		}
	}
}