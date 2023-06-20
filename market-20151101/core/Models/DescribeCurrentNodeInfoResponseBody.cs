// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeCurrentNodeInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCurrentNodeInfoResponseBodyResult Result { get; set; }
        public class DescribeCurrentNodeInfoResponseBodyResult : TeaModel {
            [NameInMap("AllowRollbackNode")]
            [Validation(Required=false)]
            public bool? AllowRollbackNode { get; set; }

            [NameInMap("AutoFinishNode")]
            [Validation(Required=false)]
            public bool? AutoFinishNode { get; set; }

            [NameInMap("FinalStepNo")]
            [Validation(Required=false)]
            public int? FinalStepNo { get; set; }

            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public long? GmtExpired { get; set; }

            [NameInMap("GmtFinished")]
            [Validation(Required=false)]
            public long? GmtFinished { get; set; }

            [NameInMap("GmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            [NameInMap("NeedAttachment")]
            [Validation(Required=false)]
            public bool? NeedAttachment { get; set; }

            [NameInMap("NextNodeId")]
            [Validation(Required=false)]
            public long? NextNodeId { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

            [NameInMap("ParentNodeId")]
            [Validation(Required=false)]
            public long? ParentNodeId { get; set; }

            [NameInMap("PreviousNodeId")]
            [Validation(Required=false)]
            public long? PreviousNodeId { get; set; }

            [NameInMap("StepNo")]
            [Validation(Required=false)]
            public int? StepNo { get; set; }

            [NameInMap("TemplateForm")]
            [Validation(Required=false)]
            public string TemplateForm { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
