// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSChunksExecutionResponseBody : TeaModel {
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
        public QueryTSChunksExecutionResponseBodyData Data { get; set; }
        public class QueryTSChunksExecutionResponseBodyData : TeaModel {
            [NameInMap("Consume")]
            [Validation(Required=false)]
            public long? Consume { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryTSChunksExecutionResponseBodyDataList> List { get; set; }
            public class QueryTSChunksExecutionResponseBodyDataList : TeaModel {
                public long? Id { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
