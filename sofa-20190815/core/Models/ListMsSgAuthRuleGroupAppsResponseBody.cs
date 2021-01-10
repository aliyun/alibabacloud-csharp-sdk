// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsSgAuthRuleGroupAppsResponseBody : TeaModel {
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

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("AuthRuleGroups")]
        [Validation(Required=false)]
        public List<ListMsSgAuthRuleGroupAppsResponseBodyAuthRuleGroups> AuthRuleGroups { get; set; }
        public class ListMsSgAuthRuleGroupAppsResponseBodyAuthRuleGroups : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("BlackGroupId")]
            [Validation(Required=false)]
            public long? BlackGroupId { get; set; }

            [NameInMap("BlackState")]
            [Validation(Required=false)]
            public long? BlackState { get; set; }

            [NameInMap("ChangeStatus")]
            [Validation(Required=false)]
            public string ChangeStatus { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("WhiteGroupId")]
            [Validation(Required=false)]
            public long? WhiteGroupId { get; set; }

            [NameInMap("WhiteState")]
            [Validation(Required=false)]
            public long? WhiteState { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListMsSgAuthRuleGroupAppsResponseBodyAuthRuleGroupsRules> Rules { get; set; }
            public class ListMsSgAuthRuleGroupAppsResponseBodyAuthRuleGroupsRules : TeaModel {
                [NameInMap("AuthRuleGroupId")]
                [Validation(Required=false)]
                public long? AuthRuleGroupId { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public long? Enabled { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("RuleItems")]
                [Validation(Required=false)]
                public List<ListMsSgAuthRuleGroupAppsResponseBodyAuthRuleGroupsRulesRuleItems> RuleItems { get; set; }
                public class ListMsSgAuthRuleGroupAppsResponseBodyAuthRuleGroupsRulesRuleItems : TeaModel {
                    [NameInMap("AuthRuleId")]
                    [Validation(Required=false)]
                    public long? AuthRuleId { get; set; }

                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

    }

}
