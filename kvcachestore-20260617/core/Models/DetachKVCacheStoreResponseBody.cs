// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class DetachKVCacheStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of unmount results.</para>
        /// </summary>
        [NameInMap("DetachResults")]
        [Validation(Required=false)]
        public List<DetachKVCacheStoreResponseBodyDetachResults> DetachResults { get; set; }
        public class DetachKVCacheStoreResponseBodyDetachResults : TeaModel {
            /// <summary>
            /// <para>The error code when the operation fails. This value is null when the operation succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KVCacheInstance.NotAttached</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message when the operation fails. This value is null when the operation succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The KVCacheInstance is not in ATTACHED status.</para>
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
            /// <item><description>DETACHING: The request has been accepted and the asynchronous unmount is in progress. This value is also returned for idempotent calls.</description></item>
            /// <item><description>Success: The synchronous validation passed and the asynchronous operation completed.</description></item>
            /// <item><description>Failed: The operation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DETACHING</para>
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
        /// <para>The request ID. A request ID is returned regardless of whether the API call succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B127704C-ECB1-5B0A-AA9C-8F394A6F179F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
