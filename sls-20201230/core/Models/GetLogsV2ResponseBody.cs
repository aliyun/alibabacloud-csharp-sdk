// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2ResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public GetLogsV2ResponseBodyMeta Meta { get; set; }
        public class GetLogsV2ResponseBodyMeta : TeaModel {
            [NameInMap("aggQuery")]
            [Validation(Required=false)]
            public string AggQuery { get; set; }

            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            [NameInMap("hasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            [NameInMap("isAccurate")]
            [Validation(Required=false)]
            public bool? IsAccurate { get; set; }

            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public int? ProcessedRows { get; set; }

            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

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
