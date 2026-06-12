// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public GetLogsV2ResponseBodyMeta Meta { get; set; }
        public class GetLogsV2ResponseBodyMeta : TeaModel {
            /// <summary>
            /// <para>The SQL part of the query statement that follows the pipe character (|).</para>
            /// 
            /// <b>Example:</b>
            /// <para>select *</para>
            /// </summary>
            [NameInMap("aggQuery")]
            [Validation(Required=false)]
            public string AggQuery { get; set; }

            /// <summary>
            /// <para>The column types.</para>
            /// </summary>
            [NameInMap("columnTypes")]
            [Validation(Required=false)]
            public List<string> ColumnTypes { get; set; }

            /// <summary>
            /// <para>The number of log entries returned in this query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The number of CPU cores used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            /// <summary>
            /// <para>The core-hours for the Exclusive SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.002</para>
            /// </summary>
            [NameInMap("cpuSec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            /// <summary>
            /// <para>The time consumed by the query, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            /// <summary>
            /// <para>Indicates whether the query is an SQL query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            /// <summary>
            /// <para>The highlighted content.</para>
            /// </summary>
            [NameInMap("highlights")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Highlights { get; set; }

            /// <summary>
            /// <para>Indicates whether nanosecond-level sorting is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isAccurate")]
            [Validation(Required=false)]
            public bool? IsAccurate { get; set; }

            /// <summary>
            /// <para>All keys in the query result.</para>
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            /// <summary>
            /// <para>The number of entries returned. This parameter is returned if the SQL statement does not contain a LIMIT clause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("limited")]
            [Validation(Required=false)]
            public int? Limited { get; set; }

            /// <summary>
            /// <para>The query mode. Valid values: 0: Normal query, which includes SQL queries. 1: Phrase query. 2: SCAN query. 3: SCAN SQL query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The information about the phrase query.</para>
            /// </summary>
            [NameInMap("phraseQueryInfo")]
            [Validation(Required=false)]
            public GetLogsV2ResponseBodyMetaPhraseQueryInfo PhraseQueryInfo { get; set; }
            public class GetLogsV2ResponseBodyMetaPhraseQueryInfo : TeaModel {
                /// <summary>
                /// <para>The starting offset of the scan result after index filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("beginOffset")]
                [Validation(Required=false)]
                public long? BeginOffset { get; set; }

                /// <summary>
                /// <para>The end offset of the scan result after index filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("endOffset")]
                [Validation(Required=false)]
                public long? EndOffset { get; set; }

                /// <summary>
                /// <para>The end time of the scan result after index filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Indicates whether all logs are scanned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("scanAll")]
                [Validation(Required=false)]
                public bool? ScanAll { get; set; }

            }

            /// <summary>
            /// <para>The volume of logs processed in the query, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            /// <summary>
            /// <para>The number of rows processed in the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// <para>The progress of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Complete: The query is complete, and the returned result is complete.</para>
            /// </description></item>
            /// <item><description><para>Incomplete: The query is complete, but the returned result is incomplete. You must send the request again to obtain the complete result.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The volume of data scanned in the scan query, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("scanBytes")]
            [Validation(Required=false)]
            public long? ScanBytes { get; set; }

            /// <summary>
            /// <para>The type of observable data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("telementryType")]
            [Validation(Required=false)]
            public string TelementryType { get; set; }

            /// <summary>
            /// <para>All terms in the query statement.</para>
            /// </summary>
            [NameInMap("terms")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Terms { get; set; }

            /// <summary>
            /// <para>The part of the query statement that precedes the pipe character (|).</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("whereQuery")]
            [Validation(Required=false)]
            public string WhereQuery { get; set; }

        }

    }

}
