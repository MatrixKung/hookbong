using System;
using System.Runtime.InteropServices;

namespace HookBong.Core.Utils
{
    [Flags]
    public enum ProcessAccessFlags : uint
    {
        All = 0x001FFFFF,
        Terminate = 0x00000001,
        CreateThread = 0x00000002,
        VirtualMemoryOperation = 0x00000008, // Nt[Allocate|Free]VirtualMemory, NtProtectVirtualMemory, NtFlushVirtualMemory, Nt[Un]LockVirtualMemory, Nt[Un]MapViewOfSection, Nt[Allocate|Free]UserPhysicalPages, Nt[Get|Reset]WriteWatch
        VirtualMemoryRead = 0x00000010, // NtReadVirtualMemory
        VirtualMemoryWrite = 0x00000020, // NtWriteVirtualMemory, NtFlushInstructionCache
        DuplicateHandle = 0x00000040,
        CreateProcess = 0x000000080,
        SetQuota = 0x00000100,
        SetInformation = 0x00000200,
        QueryInformation = 0x00000400,
        QueryLimitedInformation = 0x00001000,
        Synchronize = 0x00100000
    }

    [Flags]
    public enum PageProtection : uint
    {
        // Access
        NoAccess = 0x01,
        ReadOnly = 0x02,
        ReadWrite = 0x04,
        WriteCopy = 0x08,
        Execute = 0x10,
        ExecuteRead = 0x20,
        ExecuteReadWrite = 0x40,
        ExecuteWriteCopy = 0x80,

        // Modifiers
        Guard = 0x100,
        NoCache = 0x200,
        WriteCombine = 0x400,

        // Allocation types
        Commit = 0x1000,
        Reserve = 0x2000,
        Decommit = 0x4000,
        Release = 0x8000,
        Free = 0x10000,
        Private = 0x20000,
        Mapped = 0x40000,
        Reset = 0x80000,
        TopDown = 0x100000,
        WriteWatch = 0x200000,
        Physical = 0x400000,
        LargePages = 0x20000000,
        DosLim = 0x40000000,
        FourMbPages = 0x80000000
    }

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, UIntPtr dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In] byte[] lpBuffer, UIntPtr dwSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpBaseAddress, UIntPtr dwSize, PageProtection flNewProtect, out IntPtr lpflOldProtect);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr OpenProcess(ProcessAccessFlags accessMask, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool CloseHandle(IntPtr hObject);
    }
}
