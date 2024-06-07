// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListGovernanceIssueTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGovernanceIssueTasksResponseBodyData Data { get; set; }
        public class ListGovernanceIssueTasksResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<ListGovernanceIssueTasksResponseBodyDataTasks> Tasks { get; set; }
            public class ListGovernanceIssueTasksResponseBodyDataTasks : TeaModel {
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

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
