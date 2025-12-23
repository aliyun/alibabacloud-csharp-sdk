// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task.NotExist</para>
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
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4D487A9-A456-5AA5-A9C6-B7BF2889CF74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionTaskResponseBodyResult Result { get; set; }
        public class GetFunctionTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The timestamp that indicates the end time of the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647213406267</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The extended information, which is a JSON string.</para>
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
            /// <para>1</para>
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
            /// <para>The timestamp that indicates the start time of the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647212220000</para>
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
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
