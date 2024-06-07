// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListGovernanceIssueTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGovernanceIssueTablesResponseBodyData Data { get; set; }
        public class ListGovernanceIssueTablesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<ListGovernanceIssueTablesResponseBodyDataTables> Tables { get; set; }
            public class ListGovernanceIssueTablesResponseBodyDataTables : TeaModel {
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("DatasourceType")]
                [Validation(Required=false)]
                public string DatasourceType { get; set; }

                [NameInMap("DownstreamDependencyCount")]
                [Validation(Required=false)]
                public int? DownstreamDependencyCount { get; set; }

                [NameInMap("LastAccessTime")]
                [Validation(Required=false)]
                public long? LastAccessTime { get; set; }

                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                [NameInMap("McProjectName")]
                [Validation(Required=false)]
                public string McProjectName { get; set; }

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

                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TableSize")]
                [Validation(Required=false)]
                public long? TableSize { get; set; }

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
