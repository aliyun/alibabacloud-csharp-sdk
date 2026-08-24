// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class AttachKVCacheStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of mount results.</para>
        /// </summary>
        [NameInMap("AttachResults")]
        [Validation(Required=false)]
        public List<AttachKVCacheStoreResponseBodyAttachResults> AttachResults { get; set; }
        public class AttachKVCacheStoreResponseBodyAttachResults : TeaModel {
            /// <summary>
            /// <para>The error code returned when the operation fails. This value is null when the operation succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidStatus.OperationDenied</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the operation fails. This value is null when the operation succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The operation is not allowed for instance in ATTACHED status.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>KVCacheStore KvcsId</para>
            /// 
            /// <b>Example:</b>
            /// <para>kvcs-xxxxx</para>
            /// </summary>
            [NameInMap("KvcsId")]
            [Validation(Required=false)]
            public string KvcsId { get; set; }

            /// <summary>
            /// <para>The operation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ATTACHING: The request has been accepted and the asynchronous mount is in progress.</description></item>
            /// <item><description>ATTACHED: The resource is already mounted (idempotent).</description></item>
            /// <item><description>Success: The synchronous verification passed and the asynchronous operation is complete.</description></item>
            /// <item><description>Failed: The operation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ATTACHING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The VSC ID on the compute side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-001</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. A request ID is returned regardless of whether the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7BEF1E2-7E56-5BF1-8E36-77A51C5812F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
