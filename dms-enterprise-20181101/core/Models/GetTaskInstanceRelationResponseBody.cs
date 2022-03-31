// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskInstanceRelationResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NodeList")]
        [Validation(Required=false)]
        public GetTaskInstanceRelationResponseBodyNodeList NodeList { get; set; }
        public class GetTaskInstanceRelationResponseBodyNodeList : TeaModel {
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetTaskInstanceRelationResponseBodyNodeListNode> Node { get; set; }
            public class GetTaskInstanceRelationResponseBodyNodeListNode : TeaModel {
                public string BusinessTime { get; set; }
                public string EndTime { get; set; }
                public long? ExecuteTime { get; set; }
                public long? Id { get; set; }
                public string Message { get; set; }
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public int? NodeType { get; set; }
                public int? Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
