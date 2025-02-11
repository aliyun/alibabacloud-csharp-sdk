// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkReplStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkReplStatementResponseBodyData Data { get; set; }
        public class GetSparkReplStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>144740799645****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public long? AliyunUid { get; set; }

            /// <summary>
            /// <para>The code that is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>print(1+1)</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The code execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CANCELLED</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>SUCCEEDED</description></item>
            /// <item><description>ERROR</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("CodeState")]
            [Validation(Required=false)]
            public string CodeState { get; set; }

            /// <summary>
            /// <para>The code type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PYTHON</description></item>
            /// <item><description>SCALA</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON</para>
            /// </summary>
            [NameInMap("CodeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// <para>The column names.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>The end time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730968194000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stackoverflow error</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The code execution result, which is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;text/plain&quot;: 2}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The execution result type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE</description></item>
            /// <item><description>TEXT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("OutputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            /// <summary>
            /// <para>The start time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730968194000</para>
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
