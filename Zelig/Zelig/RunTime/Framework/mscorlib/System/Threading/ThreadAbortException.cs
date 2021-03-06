// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*=============================================================================
**
** Class: ThreadAbortException
**
**
** Purpose: An exception class which is thrown into a thread to cause it to
**          abort. This is a special non-catchable exception and results in
**			the thread's death.  This is thrown by the VM only and can NOT be
**          thrown by any user thread, and subclassing this is useless.
**
**
=============================================================================*/

namespace System.Threading 
{
    using System;
    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;

    [Serializable]
    public sealed class ThreadAbortException : SystemException 
    {
    	private ThreadAbortException() : base( GetMessageFromNativeResources( ExceptionMessageKind.ThreadAbort ) )
        {
        }

        //required for serialization
////    internal ThreadAbortException( SerializationInfo info, StreamingContext context ) : base( info, context ) 
////    {
////    }

////    public Object ExceptionState 
////    {
////		get
////        {
////            return Thread.CurrentThread.AbortReason;
////        }
////	}
    }
}
