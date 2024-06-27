// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryApprovalInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryApprovalInfoResponseBodyResult Result { get; set; }
        public class QueryApprovalInfoResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryApprovalInfoResponseBodyResultData> Data { get; set; }
            public class QueryApprovalInfoResponseBodyResultData : TeaModel {
                [NameInMap("ApplicantId")]
                [Validation(Required=false)]
                public string ApplicantId { get; set; }

                [NameInMap("ApplicantName")]
                [Validation(Required=false)]
                public string ApplicantName { get; set; }

                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                [NameInMap("ApproverId")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                [NameInMap("ApproverName")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                [NameInMap("DeleteFlag")]
                [Validation(Required=false)]
                public bool? DeleteFlag { get; set; }

                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public long? ExpireDate { get; set; }

                [NameInMap("FlagStatus")]
                [Validation(Required=false)]
                public int? FlagStatus { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("HandleReason")]
                [Validation(Required=false)]
                public string HandleReason { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
