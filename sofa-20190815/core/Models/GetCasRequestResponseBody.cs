// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetCasRequestResponseBody : TeaModel {
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
        public GetCasRequestResponseBodyData Data { get; set; }
        public class GetCasRequestResponseBodyData : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetCasRequestResponseBodyDataTasks> Tasks { get; set; }
            public class GetCasRequestResponseBodyDataTasks : TeaModel {
                public string Context { get; set; }
                public long? ExecutionTimes { get; set; }
                public string Id { get; set; }
                public string ResourceId { get; set; }
                public string ResourceType { get; set; }
                public string Status { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string WorkspaceId { get; set; }
                public GetCasRequestResponseBodyDataTasksRequest Request { get; set; }
                public class GetCasRequestResponseBodyDataTasksRequest : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                }
            }
        };

    }

}
