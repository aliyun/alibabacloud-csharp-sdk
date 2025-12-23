// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The time consumed for the request, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fail</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638157479281</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[         {             &quot;functionName&quot;: &quot;ctr&quot;,             &quot;progress&quot;: 100,             &quot;status&quot;: &quot;success&quot;,             &quot;startTime&quot;: 100010,             &quot;endTime&quot;: 200020,             &quot;extendInfo&quot;: &quot;{\&quot;recall\&quot;:91,\&quot;errors\&quot;:[]}&quot;,             &quot;runId&quot;: &quot;trigger__2021-03-05T12:18:41&quot;         }     ]</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListFunctionTasksResponseBodyResult> Result { get; set; }
        public class ListFunctionTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The timestamp that indicates the end time. Unit: milliseconds. 0 indicates that the task has not ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100010</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The value is a JSON string. It includes model evaluation information and training error information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;recall\&quot;:91,\&quot;errors\&quot;:[]}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ctr</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The number of iterations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Generation")]
            [Validation(Required=false)]
            public string Generation { get; set; }

            /// <summary>
            /// <para>The progress. 90 indicates 90%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trigger__2021-03-05T12:18:41</para>
            /// </summary>
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the start time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100010</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success</description></item>
            /// <item><description>failed</description></item>
            /// <item><description>running</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The status of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
