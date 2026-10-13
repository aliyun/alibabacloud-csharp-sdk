// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CancelContextDatabaseSyncRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CancelContextDatabaseSyncRunResponseBodyData Data { get; set; }
        public class CancelContextDatabaseSyncRunResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The run ID, a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The run status after the cancellation request is submitted. For runs in the queued or running state, the operation immediately returns cancelling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cancelling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
