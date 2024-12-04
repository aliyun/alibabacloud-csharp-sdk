// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
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
            /// <para>The SQL statement after | in the query statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select *</para>
            /// </summary>
            [NameInMap("aggQuery")]
            [Validation(Required=false)]
            public string AggQuery { get; set; }

            [NameInMap("columnTypes")]
            [Validation(Required=false)]
            public List<string> ColumnTypes { get; set; }

            /// <summary>
            /// <para>The number of rows that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.002</para>
            /// </summary>
            [NameInMap("cpuSec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            /// <summary>
            /// <para>The amount of time that is consumed by the request. Unit: milliseconds.</para>
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

            [NameInMap("highlights")]
            [Validation(Required=false)]
            public List<List<LogContent>> Highlights { get; set; }

            /// <summary>
            /// <para>Indicates whether the returned result is accurate to seconds.</para>
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
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("limited")]
            [Validation(Required=false)]
            public int? Limited { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            [NameInMap("phraseQueryInfo")]
            [Validation(Required=false)]
            public GetLogsV2ResponseBodyMetaPhraseQueryInfo PhraseQueryInfo { get; set; }
            public class GetLogsV2ResponseBodyMetaPhraseQueryInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("beginOffset")]
                [Validation(Required=false)]
                public long? BeginOffset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("endOffset")]
                [Validation(Required=false)]
                public long? EndOffset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("scanAll")]
                [Validation(Required=false)]
                public bool? ScanAll { get; set; }

            }

            /// <summary>
            /// <para>The number of logs that are processed in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            /// <summary>
            /// <para>The number of rows that are processed in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// <para>Indicates whether the query result is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Complete: The query was successful, and the complete result is returned.</description></item>
            /// <item><description>Incomplete: The query was successful, but the query result is incomplete. To obtain the complete result, you must call the operation again.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
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
            /// <para>The part before | in the query statement.</para>
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
