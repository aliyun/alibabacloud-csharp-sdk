// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListGovernanceIssueDataServiceAPIsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGovernanceIssueDataServiceAPIsResponseBodyData Data { get; set; }
        public class ListGovernanceIssueDataServiceAPIsResponseBodyData : TeaModel {
            [NameInMap("APIs")]
            [Validation(Required=false)]
            public List<ListGovernanceIssueDataServiceAPIsResponseBodyDataAPIs> APIs { get; set; }
            public class ListGovernanceIssueDataServiceAPIsResponseBodyDataAPIs : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                [NameInMap("RuleCategory")]
                [Validation(Required=false)]
                public string RuleCategory { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("DynamicErrorCode")]
        [Validation(Required=false)]
        public string DynamicErrorCode { get; set; }

        [NameInMap("DynamicErrorMessage")]
        [Validation(Required=false)]
        public string DynamicErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
