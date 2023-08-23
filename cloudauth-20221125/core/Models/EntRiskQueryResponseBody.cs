// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntRiskQueryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public EntRiskQueryResponseBodyResult Result { get; set; }
        public class EntRiskQueryResponseBodyResult : TeaModel {
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            [NameInMap("RiskList")]
            [Validation(Required=false)]
            public List<EntRiskQueryResponseBodyResultRiskList> RiskList { get; set; }
            public class EntRiskQueryResponseBodyResultRiskList : TeaModel {
                [NameInMap("CreditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                [NameInMap("EntName")]
                [Validation(Required=false)]
                public string EntName { get; set; }

                [NameInMap("ListedDate")]
                [Validation(Required=false)]
                public string ListedDate { get; set; }

                [NameInMap("ListedReason")]
                [Validation(Required=false)]
                public string ListedReason { get; set; }

                [NameInMap("OperationOrg")]
                [Validation(Required=false)]
                public string OperationOrg { get; set; }

                [NameInMap("RegNo")]
                [Validation(Required=false)]
                public string RegNo { get; set; }

                [NameInMap("RemovedDate")]
                [Validation(Required=false)]
                public string RemovedDate { get; set; }

                [NameInMap("RemovedOrg")]
                [Validation(Required=false)]
                public string RemovedOrg { get; set; }

                [NameInMap("RemovedReason")]
                [Validation(Required=false)]
                public string RemovedReason { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
