﻿using System;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation.Metadata;

namespace Windows.Win32.System.JobObjects
{
    [Flags]
    public enum JOB_OBJECT_LIMIT : uint
    {
        JOB_OBJECT_LIMIT_WORKINGSET = 0x00000001,
        JOB_OBJECT_LIMIT_PROCESS_TIME = 0x00000002,
        JOB_OBJECT_LIMIT_JOB_TIME = 0x00000004,
        JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 0x00000008,
        JOB_OBJECT_LIMIT_AFFINITY = 0x00000010,
        JOB_OBJECT_LIMIT_PRIORITY_CLASS = 0x00000020,
        JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 0x00000040,
        JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 0x00000080,
        JOB_OBJECT_LIMIT_PROCESS_MEMORY = 0x00000100,
        JOB_OBJECT_LIMIT_JOB_MEMORY = 0x00000200,
        JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = JOB_OBJECT_LIMIT_JOB_MEMORY,
        JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 0x00000400,
        JOB_OBJECT_LIMIT_BREAKAWAY_OK = 0x00000800,
        JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 0x00001000,
        JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x00002000,
        JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 0x00004000,
        JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = 0x00008000,
        JOB_OBJECT_LIMIT_JOB_READ_BYTES = 0x00010000,
        JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = 0x00020000,
        JOB_OBJECT_LIMIT_RATE_CONTROL = 0x00040000,
        JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = JOB_OBJECT_LIMIT_RATE_CONTROL,
        JOB_OBJECT_LIMIT_IO_RATE_CONTROL = 0x00080000,
        JOB_OBJECT_LIMIT_NET_RATE_CONTROL = 0x00100000,
        JOB_OBJECT_LIMIT_VALID_FLAGS = 0x0007ffff,
        JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 0x000000ff,
        JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 0x00007fff,
        JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS = (JOB_OBJECT_LIMIT_JOB_READ_BYTES | JOB_OBJECT_LIMIT_JOB_WRITE_BYTES | JOB_OBJECT_LIMIT_JOB_TIME | JOB_OBJECT_LIMIT_JOB_MEMORY_LOW | JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH | JOB_OBJECT_LIMIT_CPU_RATE_CONTROL | JOB_OBJECT_LIMIT_IO_RATE_CONTROL | JOB_OBJECT_LIMIT_NET_RATE_CONTROL),
    }

    [Flags]
    public enum JOB_OBJECT_UILIMIT : uint
    {
        JOB_OBJECT_UILIMIT_NONE = 0x00000000,
        JOB_OBJECT_UILIMIT_HANDLES = 0x00000001,
        JOB_OBJECT_UILIMIT_READCLIPBOARD = 0x00000002,
        JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 0x00000004,
        JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 0x00000008,
        JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 0x00000010,
        JOB_OBJECT_UILIMIT_GLOBALATOMS = 0x00000020,
        JOB_OBJECT_UILIMIT_DESKTOP = 0x00000040,
        JOB_OBJECT_UILIMIT_EXITWINDOWS = 0x00000080
    }

    [Flags]
    public enum JOB_OBJECT_SECURITY : uint
    {
        JOB_OBJECT_SECURITY_NO_ADMIN = 0x00000001,
        JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 0x00000002,
        JOB_OBJECT_SECURITY_ONLY_TOKEN = 0x00000004,
        JOB_OBJECT_SECURITY_FILTER_TOKENS = 0x00000008,
        JOB_OBJECT_SECURITY_VALID_FLAGS = 0x0000000f
    }
}
