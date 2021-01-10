// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasRequestTaskResponseBody : TeaModel {
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
        public List<QueryCasRequestTaskResponseBodyData> Data { get; set; }
        public class QueryCasRequestTaskResponseBodyData : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("ExecutionTimes")]
            [Validation(Required=false)]
            public long? ExecutionTimes { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("Request")]
            [Validation(Required=false)]
            public QueryCasRequestTaskResponseBodyDataRequest Request { get; set; }
            public class QueryCasRequestTaskResponseBodyDataRequest : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

        }

    }

}
