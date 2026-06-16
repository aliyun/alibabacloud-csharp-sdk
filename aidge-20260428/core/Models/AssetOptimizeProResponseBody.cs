// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AssetOptimizeProResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The value &quot;success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result data of the asynchronous task submission, which contains the asynchronous task ID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssetOptimizeProResponseBodyData Data { get; set; }
        public class AssetOptimizeProResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID, which is used to query the processing result by calling QueryAsyncTaskResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080345d-b28a-9e2e-9ad7-370f8e236949</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message. The value &quot;Success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FCCA90A-A7A4-1D37-88C3-C17549886E70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
