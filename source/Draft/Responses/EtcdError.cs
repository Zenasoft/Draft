﻿using System;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json.Serialization;

namespace Draft.Responses
{
    [DataContract]
    internal class EtcdError : IEtcdError
    {

        [DataMember(Name = "cause")]
        public string Cause { get; private set; }

        [DataMember(Name = "errorCode")]
        public EtcdErrorCode? ErrorCode { get; internal set; }

        [DataMember(Name = "index")]
        public long? Index { get; private set; }

        [DataMember(Name = "message")]
        public string Message { get; private set; }

#if DEBUG
        [OnError, System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public void OnDeserializing(StreamingContext context, ErrorContext errorContext)
        {
            System.Diagnostics.Debugger.Break();
        }
#endif


    }
}
