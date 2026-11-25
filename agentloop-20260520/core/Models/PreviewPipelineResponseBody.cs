// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class PreviewPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of sample rows. This array of maps includes only the first N rows (up to 5 rows by default) and does not reflect the complete write plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;: &quot;saturation&quot;, &quot;value&quot;: 0}, {&quot;type&quot;: &quot;load&quot;, &quot;value&quot;: 0}, {&quot;type&quot;: &quot;latency&quot;, &quot;value&quot;: 1}, {&quot;type&quot;: &quot;error&quot;, &quot;value&quot;: 0}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        /// <summary>
        /// <para>The query metadata.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public PreviewPipelineResponseBodyMeta Meta { get; set; }
        public class PreviewPipelineResponseBodyMeta : TeaModel {
            /// <summary>
            /// <para>The SPL statement for aggregation analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>| SELECT status, count(*) AS cnt GROUP BY status</description></item>
            /// </list>
            /// </summary>
            [NameInMap("aggQuery")]
            [Validation(Required=false)]
            public string AggQuery { get; set; }

            /// <summary>
            /// <para>The mapping from column names to data types, such as string, long, double, or json.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;long&quot;,&quot;string&quot;]</para>
            /// </summary>
            [NameInMap("columnTypes")]
            [Validation(Required=false)]
            public List<string> ColumnTypes { get; set; }

            /// <summary>
            /// <para>The number of matched log entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The number of consumed CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            /// <summary>
            /// <para>The consumed CPU time in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("cpuSec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            /// <summary>
            /// <para>The query duration in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            /// <summary>
            /// <para>Indicates whether an SQL query is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            /// <summary>
            /// <para>Indicates whether nanosecond-level ordering is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isAccurate")]
            [Validation(Required=false)]
            public bool? IsAccurate { get; set; }

            /// <summary>
            /// <para>The list of result column names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;status&quot;,&quot;method&quot;,&quot;path&quot;]</para>
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            /// <summary>
            /// <para>The maximum number of returned rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("limited")]
            [Validation(Required=false)]
            public int? Limited { get; set; }

            /// <summary>
            /// <para>The query mode identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The number of processed data bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524288</para>
            /// </summary>
            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            /// <summary>
            /// <para>The number of processed log rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// <para>The Simple Log Service (SLS) query progress. A value of Complete indicates that the query is finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The number of scanned raw data bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("scanBytes")]
            [Validation(Required=false)]
            public long? ScanBytes { get; set; }

            /// <summary>
            /// <para>The dataset schema for the final output of the pipeline. The keys are field names, and the type in the values supports text, long, double, and json. The field order is determined by the keys field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;status&quot;:{&quot;type&quot;:&quot;long&quot;}}</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public Dictionary<string, MetaSchemaValue> Schema { get; set; }

            /// <summary>
            /// <para>The column types and aggregation information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;column&quot;:&quot;status&quot;,&quot;type&quot;:&quot;long&quot;}]</para>
            /// </summary>
            [NameInMap("terms")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Terms { get; set; }

            /// <summary>
            /// <para>The SPL statement for the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>status: 200</para>
            /// </summary>
            [NameInMap("whereQuery")]
            [Validation(Required=false)]
            public string WhereQuery { get; set; }

        }

        /// <summary>
        /// <para>The request ID used to locate the request during troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
