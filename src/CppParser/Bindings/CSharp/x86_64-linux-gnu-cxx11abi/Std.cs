//----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

namespace Std
{
}

namespace GnuCxx
{
}

namespace Std
{
    namespace ExceptionPtr
    {
        public unsafe partial class ExceptionPtr
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr _M_exception_object;
            }
        }
    }
}

namespace Std
{
    public unsafe partial class Allocator : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcEC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcED2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.Allocator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Allocator(native.ToPointer(), skipVTables);
        }

        internal static global::Std.Allocator __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new Allocator(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(0);
            *(global::Std.Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Allocator()
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            global::Std.Allocator.__Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            global::Std.Allocator __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                global::Std.Allocator.__Internal.dtor_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }
    }


    public unsafe partial class Rebind
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }
    }
}

namespace Std
{
    namespace VectorBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.VectorBase.VectorImpl.__Internal _M_impl;
        }


        public unsafe partial class VectorImpl
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }

    namespace Vector
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.VectorBase.VectorImpl.__Internal _M_impl;
        }
    }
}

namespace Std
{
    public unsafe partial class BitIterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr _M_p;

            [FieldOffset(8)]
            public uint _M_offset;
        }
    }

    public unsafe partial class BitConstIterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr _M_p;

            [FieldOffset(8)]
            public uint _M_offset;
        }
    }
}

namespace Std
{
    namespace Less
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }
}

namespace Std
{
    public enum RbTreeColor : uint
    {
        _S_red = 0,
        _S_black = 1
    }

    namespace RbTree
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTree.RbTreeImpl.__Internal _M_impl;
        }


        public unsafe partial class ReuseOrAllocNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class AllocNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class RbTreeImpl
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }

    public unsafe partial class RbTreeNodeBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public global::Std.RbTreeColor _M_color;

            [FieldOffset(8)]
            public global::System.IntPtr _M_parent;

            [FieldOffset(16)]
            public global::System.IntPtr _M_left;

            [FieldOffset(24)]
            public global::System.IntPtr _M_right;
        }
    }
}

namespace GnuCxx
{
}

namespace Std
{
    namespace Map
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTree.__Internal _M_t;
        }


        public unsafe partial class ValueCompare
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace Cxx11
    {
    }

    namespace Cxx11
    {
    }
}

public unsafe partial class MbstateT
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public int __count;

        [FieldOffset(4)]
        internal global::MbstateT._.__Internal __value;
    }

    public unsafe partial struct _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public uint __wch;

            [FieldOffset(0)]
            public fixed sbyte __wchb[4];
        }
    }
}

namespace Std
{
}

namespace Std
{
}

public unsafe partial class Timespec
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public long tv_sec;

        [FieldOffset(8)]
        public long tv_nsec;
    }
}

public unsafe partial class Timeval
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public long tv_sec;

        [FieldOffset(8)]
        public long tv_usec;
    }
}

public unsafe partial class PthreadInternalList
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public global::System.IntPtr __prev;

        [FieldOffset(8)]
        public global::System.IntPtr __next;
    }
}

public unsafe partial struct PthreadMutexT
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadMutexT.PthreadMutexS.__Internal __data;

        [FieldOffset(0)]
        public fixed sbyte __size[40];

        [FieldOffset(0)]
        public long __align;
    }

    public unsafe partial class PthreadMutexS
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public int __lock;

            [FieldOffset(4)]
            public uint __count;

            [FieldOffset(8)]
            public int __owner;

            [FieldOffset(12)]
            public uint __nusers;

            [FieldOffset(16)]
            public int __kind;

            [FieldOffset(20)]
            public short __spins;

            [FieldOffset(22)]
            public short __elision;

            [FieldOffset(24)]
            internal global::PthreadInternalList.__Internal __list;
        }
    }
}

public unsafe partial struct PthreadCondT
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadCondT._.__Internal __data;

        [FieldOffset(0)]
        public fixed sbyte __size[48];

        [FieldOffset(0)]
        public long __align;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public int __lock;

            [FieldOffset(4)]
            public uint __futex;

            [FieldOffset(8)]
            public ulong __total_seq;

            [FieldOffset(16)]
            public ulong __wakeup_seq;

            [FieldOffset(24)]
            public ulong __woken_seq;

            [FieldOffset(32)]
            public global::System.IntPtr __mutex;

            [FieldOffset(40)]
            public uint __nwaiters;

            [FieldOffset(44)]
            public uint __broadcast_seq;
        }
    }
}

public unsafe partial struct PthreadRwlockT
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadRwlockT._.__Internal __data;

        [FieldOffset(0)]
        public fixed sbyte __size[56];

        [FieldOffset(0)]
        public long __align;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public int __lock;

            [FieldOffset(4)]
            public uint __nr_readers;

            [FieldOffset(8)]
            public uint __readers_wakeup;

            [FieldOffset(12)]
            public uint __writer_wakeup;

            [FieldOffset(16)]
            public uint __nr_readers_queued;

            [FieldOffset(20)]
            public uint __nr_writers_queued;

            [FieldOffset(24)]
            public int __writer;

            [FieldOffset(28)]
            public int __shared;

            [FieldOffset(32)]
            public sbyte __rwelision;

            [FieldOffset(33)]
            public fixed byte __pad1[7];

            [FieldOffset(40)]
            public ulong __pad2;

            [FieldOffset(48)]
            public uint __flags;
        }
    }
}

public unsafe partial class PthreadUnwindBufT
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed byte __cancel_jmp_buf[72];

        [FieldOffset(72)]
        public void* __pad;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 72)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public fixed long __cancel_jmp_buf[8];

            [FieldOffset(64)]
            public int __mask_was_saved;
        }
    }
}

namespace Std
{
    namespace Cxx11
    {
        public unsafe partial class BasicString : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.Cxx11.BasicString.AllocHider.__Internal _M_dataplus;

                [FieldOffset(8)]
                public ulong _M_string_length;

                [FieldOffset(16)]
                internal global::Std.Cxx11.BasicString._.__Internal _;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEED2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEE5c_strEv")]
                internal static extern global::System.IntPtr CStr_0(global::System.IntPtr instance);
            }

            internal enum SLocalCapacity : uint
            {
                _S_local_capacity = 15
            }

            public unsafe partial class AllocHider
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    public global::System.IntPtr _M_p;
                }
            }

            public unsafe partial struct _
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    public fixed sbyte _M_local_buf[16];

                    [FieldOffset(0)]
                    public ulong _M_allocated_capacity;
                }
            }

            public global::System.IntPtr __Instance { get; protected set; }

            protected int __PointerAdjustment;
            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Cxx11.BasicString> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Cxx11.BasicString>();
            protected void*[] __OriginalVTables;

            protected bool __ownsNativeInstance;

            internal static global::Std.Cxx11.BasicString __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new BasicString(native.ToPointer(), skipVTables);
            }

            internal static global::Std.Cxx11.BasicString __CreateInstance(global::Std.Cxx11.BasicString.__Internal native, bool skipVTables = false)
            {
                return new BasicString(native, skipVTables);
            }

            private static void* __CopyValue(global::Std.Cxx11.BasicString.__Internal native)
            {
                var ret = Marshal.AllocHGlobal(32);
                *(global::Std.Cxx11.BasicString.__Internal*) ret = native;
                return ret.ToPointer();
            }

            private BasicString(global::Std.Cxx11.BasicString.__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected BasicString(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            public virtual void Dispose(bool disposing)
            {
                global::Std.Cxx11.BasicString __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (disposing)
                    global::Std.Cxx11.BasicString.__Internal.dtor_0((__Instance + __PointerAdjustment));
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public string CStr()
            {
                var __ret = global::Std.Cxx11.BasicString.__Internal.CStr_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }


        public unsafe partial class AllocHider
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

public unsafe partial struct Wait
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public int w_status;

        [FieldOffset(0)]
        internal global::Wait._.__Internal __wait_terminated;

        [FieldOffset(0)]
        internal global::Wait.__.__Internal __wait_stopped;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public uint __w_termsig;

            [FieldOffset(0)]
            public uint __w_coredump;

            [FieldOffset(1)]
            public uint __w_retcode;

            [FieldOffset(2)]
            public uint __;
        }
    }

    public unsafe partial class __
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public uint __w_stopval;

            [FieldOffset(1)]
            public uint __w_stopsig;

            [FieldOffset(2)]
            public uint __;
        }
    }
}

namespace Std
{
    namespace Cxx11
    {
    }

    namespace Cxx11
    {
    }
}

namespace Std
{
    public unsafe partial class CowString
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.CowString._.__Internal _;
        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr _M_p;

                [FieldOffset(0)]
                public fixed sbyte _M_bytes[8];
            }
        }
    }
}

namespace Std
{
    public unsafe partial class UsesAlloc0
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.UsesAlloc0.Sink.__Internal _M_a;
        }

        public unsafe partial class Sink
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
}
