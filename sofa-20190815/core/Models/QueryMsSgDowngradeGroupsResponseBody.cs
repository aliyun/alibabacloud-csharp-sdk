// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsSgDowngradeGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("DowngradeRuleGroups")]
        [Validation(Required=false)]
        public List<QueryMsSgDowngradeGroupsResponseBodyDowngradeRuleGroups> DowngradeRuleGroups { get; set; }
        public class QueryMsSgDowngradeGroupsResponseBodyDowngradeRuleGroups : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("DowngradeRules")]
            [Validation(Required=false)]
            public List<QueryMsSgDowngradeGroupsResponseBodyDowngradeRuleGroupsDowngradeRules> DowngradeRules { get; set; }
            public class QueryMsSgDowngradeGroupsResponseBodyDowngradeRuleGroupsDowngradeRules : TeaModel {
                [NameInMap("DowngradeAction")]
                [Validation(Required=false)]
                public string DowngradeAction { get; set; }

                [NameInMap("DowngradeMethod")]
                [Validation(Required=false)]
                public string DowngradeMethod { get; set; }

                [NameInMap("DowngradeService")]
                [Validation(Required=false)]
                public string DowngradeService { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public long? Enabled { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

    }

}
