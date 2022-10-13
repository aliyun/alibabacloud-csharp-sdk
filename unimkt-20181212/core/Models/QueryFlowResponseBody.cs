// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class QueryFlowResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryFlowResponseBodyModel Model { get; set; }
        public class QueryFlowResponseBodyModel : TeaModel {
            [NameInMap("ApplyUserId")]
            [Validation(Required=false)]
            public string ApplyUserId { get; set; }

            [NameInMap("ApproveTime")]
            [Validation(Required=false)]
            public long? ApproveTime { get; set; }

            [NameInMap("ApproveUserId")]
            [Validation(Required=false)]
            public string ApproveUserId { get; set; }

            [NameInMap("BusinessKey")]
            [Validation(Required=false)]
            public string BusinessKey { get; set; }

            [NameInMap("ChildStatus")]
            [Validation(Required=false)]
            public string ChildStatus { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public long? GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public long? GmtModifiedTime { get; set; }

            [NameInMap("NewData")]
            [Validation(Required=false)]
            public string NewData { get; set; }

            [NameInMap("OldData")]
            [Validation(Required=false)]
            public string OldData { get; set; }

            [NameInMap("ReasonType")]
            [Validation(Required=false)]
            public string ReasonType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
