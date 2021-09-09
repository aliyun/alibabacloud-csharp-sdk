// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListShardRecoveriesResponseBodyResult> Result { get; set; }
        public class ListShardRecoveriesResponseBodyResult : TeaModel {
            [NameInMap("index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            [NameInMap("sourceHost")]
            [Validation(Required=false)]
            public string SourceHost { get; set; }

            [NameInMap("sourceNode")]
            [Validation(Required=false)]
            public string SourceNode { get; set; }

            [NameInMap("filesTotal")]
            [Validation(Required=false)]
            public long? FilesTotal { get; set; }

            [NameInMap("bytesPercent")]
            [Validation(Required=false)]
            public string BytesPercent { get; set; }

            [NameInMap("translogOps")]
            [Validation(Required=false)]
            public long? TranslogOps { get; set; }

            [NameInMap("translogOpsPercent")]
            [Validation(Required=false)]
            public string TranslogOpsPercent { get; set; }

            [NameInMap("bytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            [NameInMap("targetHost")]
            [Validation(Required=false)]
            public string TargetHost { get; set; }

            [NameInMap("targetNode")]
            [Validation(Required=false)]
            public string TargetNode { get; set; }

            [NameInMap("filesPercent")]
            [Validation(Required=false)]
            public string FilesPercent { get; set; }

            [NameInMap("stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

        }

    }

}
