// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSChunkResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTSChunkResponseBodyData Data { get; set; }
        public class QueryTSChunkResponseBodyData : TeaModel {
            [NameInMap("AllNum")]
            [Validation(Required=false)]
            public long? AllNum { get; set; }
            [NameInMap("ChunkData")]
            [Validation(Required=false)]
            public string ChunkData { get; set; }
            [NameInMap("Consume")]
            [Validation(Required=false)]
            public long? Consume { get; set; }
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }
            [NameInMap("ExecuteClient")]
            [Validation(Required=false)]
            public string ExecuteClient { get; set; }
            [NameInMap("ExecuteId")]
            [Validation(Required=false)]
            public string ExecuteId { get; set; }
            [NameInMap("GenerateClient")]
            [Validation(Required=false)]
            public string GenerateClient { get; set; }
            [NameInMap("GmtBegin")]
            [Validation(Required=false)]
            public string GmtBegin { get; set; }
            [NameInMap("GmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
            [NameInMap("ShardingRule")]
            [Validation(Required=false)]
            public string ShardingRule { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("SuccessNum")]
            [Validation(Required=false)]
            public long? SuccessNum { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

    }

}
