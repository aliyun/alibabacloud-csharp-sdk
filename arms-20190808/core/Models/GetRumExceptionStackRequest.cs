// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumExceptionStackRequest : TeaModel {
        /// <summary>
        /// The binary images, which represent all executable files loaded into the process address space when a crash occurs.
        /// </summary>
        [NameInMap("ExceptionBinaryImages")]
        [Validation(Required=false)]
        public string ExceptionBinaryImages { get; set; }

        /// <summary>
        /// The exception stack information. Set the value to a JSON string. call_stack.info represents the stack information, call_stack.thread.name represents the thread name, and call_stack.thread.id represents the thread ID. This parameter is exactly the same as the exception.stack parameter in the logstore-rum Logstore of Simple Log Service.
        /// </summary>
        [NameInMap("ExceptionStack")]
        [Validation(Required=false)]
        public string ExceptionStack { get; set; }

        /// <summary>
        /// The ID of the exception thread.
        /// </summary>
        [NameInMap("ExceptionThreadId")]
        [Validation(Required=false)]
        public string ExceptionThreadId { get; set; }

        /// <summary>
        /// The application ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The file type. Valid values:
        /// 
        /// - source-map: SourceMap files
        /// - mapping: symbol table files for Android
        /// - dsym: dSYM files for iOS
        /// </summary>
        [NameInMap("SourcemapType")]
        [Validation(Required=false)]
        public string SourcemapType { get; set; }

    }

}
