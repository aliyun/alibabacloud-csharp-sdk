// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetCloudResourceDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The total list of returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<List<string>> Data { get; set; }

        /// <summary>
        /// <para>The list of headers.</para>
        /// </summary>
        [NameInMap("header")]
        [Validation(Required=false)]
        public List<string> Header { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result status.</para>
        /// </summary>
        [NameInMap("responseStatus")]
        [Validation(Required=false)]
        public GetCloudResourceDataResponseBodyResponseStatus ResponseStatus { get; set; }
        public class GetCloudResourceDataResponseBodyResponseStatus : TeaModel {
            /// <summary>
            /// <para>The information during execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("executionStates")]
            [Validation(Required=false)]
            public string ExecutionStates { get; set; }

            /// <summary>
            /// <para>The status level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Info,Warn,Error</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success,PartialSuccess,Error</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The retry policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None,Once,Continuous</para>
            /// </summary>
            [NameInMap("retryPolicy")]
            [Validation(Required=false)]
            public string RetryPolicy { get; set; }

            /// <summary>
            /// <para>The detailed status information.</para>
            /// </summary>
            [NameInMap("statusItem")]
            [Validation(Required=false)]
            public List<GetCloudResourceDataResponseBodyResponseStatusStatusItem> StatusItem { get; set; }
            public class GetCloudResourceDataResponseBodyResponseStatusStatusItem : TeaModel {
                /// <summary>
                /// <para>The status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success,ExecuteTimeout,UModelNotExist</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The status level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Info,Warn,Error</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The suggestion when an execution error occurs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try to reduce the query scope or increase timeout limit, then retry</para>
                /// </summary>
                [NameInMap("suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

        }

    }

}
