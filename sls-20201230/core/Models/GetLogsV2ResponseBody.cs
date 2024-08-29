// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2ResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        /// <summary>
        /// The metadata of the returned data.
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public GetLogsV2ResponseBodyMeta Meta { get; set; }
        public class GetLogsV2ResponseBodyMeta : TeaModel {
            /// <summary>
            /// The SQL statement after | in the query statement.
            /// </summary>
            [NameInMap("aggQuery")]
            [Validation(Required=false)]
            public string AggQuery { get; set; }

            [NameInMap("columnTypes")]
            [Validation(Required=false)]
            public List<string> ColumnTypes { get; set; }

            /// <summary>
            /// The number of rows that are returned.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            [NameInMap("cpuSec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            /// <summary>
            /// The amount of time that is consumed by the request. Unit: milliseconds.
            /// </summary>
            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            /// <summary>
            /// Indicates whether the query is an SQL query.
            /// </summary>
            [NameInMap("hasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            [NameInMap("highlights")]
            [Validation(Required=false)]
            public List<List<LogContent>> Highlights { get; set; }

            /// <summary>
            /// Indicates whether the returned result is accurate to seconds.
            /// </summary>
            [NameInMap("isAccurate")]
            [Validation(Required=false)]
            public bool? IsAccurate { get; set; }

            /// <summary>
            /// All keys in the query result.
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            [NameInMap("limited")]
            [Validation(Required=false)]
            public int? Limited { get; set; }

            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            [NameInMap("phraseQueryInfo")]
            [Validation(Required=false)]
            public GetLogsV2ResponseBodyMetaPhraseQueryInfo PhraseQueryInfo { get; set; }
            public class GetLogsV2ResponseBodyMetaPhraseQueryInfo : TeaModel {
                [NameInMap("beginOffset")]
                [Validation(Required=false)]
                public long? BeginOffset { get; set; }

                [NameInMap("endOffset")]
                [Validation(Required=false)]
                public long? EndOffset { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("scanAll")]
                [Validation(Required=false)]
                public bool? ScanAll { get; set; }

            }

            /// <summary>
            /// The number of logs that are processed in the request.
            /// </summary>
            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            /// <summary>
            /// The number of rows that are processed in the request.
            /// </summary>
            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public int? ProcessedRows { get; set; }

            /// <summary>
            /// Indicates whether the query result is complete. Valid values:
            /// 
            /// *   Complete: The query was successful, and the complete result is returned.
            /// *   Incomplete: The query was successful, but the query result is incomplete. To obtain the complete result, you must call the operation again.
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("scanBytes")]
            [Validation(Required=false)]
            public long? ScanBytes { get; set; }

            /// <summary>
            /// The type of observable data.
            /// </summary>
            [NameInMap("telementryType")]
            [Validation(Required=false)]
            public string TelementryType { get; set; }

            /// <summary>
            /// All terms in the query statement.
            /// </summary>
            [NameInMap("terms")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Terms { get; set; }

            /// <summary>
            /// The part before | in the query statement.
            /// </summary>
            [NameInMap("whereQuery")]
            [Validation(Required=false)]
            public string WhereQuery { get; set; }

        }

    }

}
