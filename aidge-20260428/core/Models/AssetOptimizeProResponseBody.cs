// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AssetOptimizeProResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of success indicates a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submission result of the asynchronous task, which includes the asynchronous task ID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssetOptimizeProResponseBodyData Data { get; set; }
        public class AssetOptimizeProResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the asynchronous task, which is used to query the processing result by calling QueryAsyncTaskResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080345d-b28a-9e2e-9ad7-370f8e236949</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message. A value of Success is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to identify a unique request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FCCA90A-A7A4-1D37-88C3-C17549886E70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
