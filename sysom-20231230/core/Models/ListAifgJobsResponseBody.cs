// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAifgJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data under the root node.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAifgJobsResponseBodyData> Data { get; set; }
        public class ListAifgJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The first command in the data list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("command")]
            [Validation(Required=false)]
            public object Command { get; set; }

            /// <summary>
            /// <para>The ID of the first element in the data list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The first parameter in the root data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;key1\&quot;: \&quot;value1\&quot;}</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public object Params { get; set; }

            /// <summary>
            /// <para>The first result in the root data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public object Result { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-service</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The status of the data item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-status of the data item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>processing</para>
            /// </summary>
            [NameInMap("subStatus")]
            [Validation(Required=false)]
            public string SubStatus { get; set; }

            /// <summary>
            /// <para>The time when the data was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-01 12:00:00</para>
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The unique identifier of the trace task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>T123456789</para>
            /// </summary>
            [NameInMap("traceTaskId")]
            [Validation(Required=false)]
            public string TraceTaskId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to retrieve in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates the position read by the current call. An empty value indicates that all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, World!</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <remarks>
        /// <para>A non-empty value indicates that more data is available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>U+w1wv2R4ZWR5oZLXD0+Dp4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
