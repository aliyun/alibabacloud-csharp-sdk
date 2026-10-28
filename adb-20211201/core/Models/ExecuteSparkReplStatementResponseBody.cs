// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ExecuteSparkReplStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteSparkReplStatementResponseBodyData Data { get; set; }
        public class ExecuteSparkReplStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17108278707****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public long? AliyunUid { get; set; }

            /// <summary>
            /// <para>The executed code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>print(1+1)</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The execution status of the code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CANCELLED: The execution is canceled.</description></item>
            /// <item><description>RUNNING: The execution is in progress.</description></item>
            /// <item><description>SUCCEEDED: The execution is successful.</description></item>
            /// <item><description>ERROR: The execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("CodeState")]
            [Validation(Required=false)]
            public string CodeState { get; set; }

            /// <summary>
            /// <para>The type of the code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SCALA</description></item>
            /// <item><description>PYTHON</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON</para>
            /// </summary>
            [NameInMap("CodeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// <para>The array of column names.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>The end time. The time is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730968125000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StackOverflow Exception</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The code execution result. It is a JSON-formatted string that follows the Apache Livy output standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;text/plain&quot;: 2}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The serialization format of the execution result. The structure is a JSON object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TEXT: The output is text content that follows the Apache Livy standard.</description></item>
            /// <item><description>TABLE: The output is table content that follows the Apache Livy standard.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("OutputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            /// <summary>
            /// <para>The start time. The time is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730968125000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The unique ID of the code block in the Spark job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("StatementId")]
            [Validation(Required=false)]
            public long? StatementId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
