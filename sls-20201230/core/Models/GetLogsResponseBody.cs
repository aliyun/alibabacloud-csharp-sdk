// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public GetLogsResponseBodyMeta Meta { get; set; }
        public class GetLogsResponseBodyMeta : TeaModel {
            [NameInMap("aggQuery")]
            [Validation(Required=false)]
            public string AggQuery { get; set; }

            [NameInMap("columnTypes")]
            [Validation(Required=false)]
            public List<string> ColumnTypes { get; set; }

            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            [NameInMap("cpuSec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            [NameInMap("hasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            [NameInMap("highlights")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Highlights { get; set; }

            [NameInMap("isAccurate")]
            [Validation(Required=false)]
            public bool? IsAccurate { get; set; }

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
            public GetLogsResponseBodyMetaPhraseQueryInfo PhraseQueryInfo { get; set; }
            public class GetLogsResponseBodyMetaPhraseQueryInfo : TeaModel {
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

            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("scanBytes")]
            [Validation(Required=false)]
            public long? ScanBytes { get; set; }

            [NameInMap("telementryType")]
            [Validation(Required=false)]
            public string TelementryType { get; set; }

            [NameInMap("terms")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Terms { get; set; }

            [NameInMap("whereQuery")]
            [Validation(Required=false)]
            public string WhereQuery { get; set; }

        }

    }

}
