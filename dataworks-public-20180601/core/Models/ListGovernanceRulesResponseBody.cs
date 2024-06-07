// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListGovernanceRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGovernanceRulesResponseBodyData Data { get; set; }
        public class ListGovernanceRulesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListGovernanceRulesResponseBodyDataRules> Rules { get; set; }
            public class ListGovernanceRulesResponseBodyDataRules : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Guide")]
                [Validation(Required=false)]
                public string Guide { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IssueType")]
                [Validation(Required=false)]
                public string IssueType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

            }

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
