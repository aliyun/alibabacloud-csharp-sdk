// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetEntityStoreDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Total list of returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<List<string>> Data { get; set; }

        /// <summary>
        /// <para>List of request headers</para>
        /// </summary>
        [NameInMap("header")]
        [Validation(Required=false)]
        public List<string> Header { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result status</para>
        /// </summary>
        [NameInMap("responseStatus")]
        [Validation(Required=false)]
        public GetEntityStoreDataResponseBodyResponseStatus ResponseStatus { get; set; }
        public class GetEntityStoreDataResponseBodyResponseStatus : TeaModel {
            /// <summary>
            /// <para>Information during the execution process</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("executionStates")]
            [Validation(Required=false)]
            public string ExecutionStates { get; set; }

            /// <summary>
            /// <para>Status level</para>
            /// 
            /// <b>Example:</b>
            /// <para>Info,Warn,Error</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Execution result</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success,PartialSuccess,Error</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>Retry policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>None,Once,Continuous</para>
            /// </summary>
            [NameInMap("retryPolicy")]
            [Validation(Required=false)]
            public string RetryPolicy { get; set; }

            /// <summary>
            /// <para>Detailed status information list</para>
            /// </summary>
            [NameInMap("statusItem")]
            [Validation(Required=false)]
            public List<GetEntityStoreDataResponseBodyResponseStatusStatusItem> StatusItem { get; set; }
            public class GetEntityStoreDataResponseBodyResponseStatusStatusItem : TeaModel {
                /// <summary>
                /// <para>Status code</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success,ExecuteTimeout,UModelNotExist</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Status level</para>
                /// 
                /// <b>Example:</b>
                /// <para>Info,Warn,Error</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Calculation execution information</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query execution timeout after 30 seconds</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Suggestions when an error occurs during execution</para>
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
