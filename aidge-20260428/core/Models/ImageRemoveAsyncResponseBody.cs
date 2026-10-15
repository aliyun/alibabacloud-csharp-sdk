// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemoveAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code, such as &quot;success&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageRemoveAsyncResponseBodyData Data { get; set; }
        public class ImageRemoveAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task ID used to query the result of the asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TID_550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message, such as &quot;The parameters contain sensitive information. Please try another input.&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to identify a unique request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values: true (success) and false (failure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
