// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveMsSgAuthRuleGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AuthRuleGroups")]
        [Validation(Required=false)]
        public List<SaveMsSgAuthRuleGroupsResponseBodyAuthRuleGroups> AuthRuleGroups { get; set; }
        public class SaveMsSgAuthRuleGroupsResponseBodyAuthRuleGroups : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<SaveMsSgAuthRuleGroupsResponseBodyAuthRuleGroupsRules> Rules { get; set; }
            public class SaveMsSgAuthRuleGroupsResponseBodyAuthRuleGroupsRules : TeaModel {
                [NameInMap("AuthRuleGroupId")]
                [Validation(Required=false)]
                public long? AuthRuleGroupId { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public long? Enabled { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleItems")]
                [Validation(Required=false)]
                public List<SaveMsSgAuthRuleGroupsResponseBodyAuthRuleGroupsRulesRuleItems> RuleItems { get; set; }
                public class SaveMsSgAuthRuleGroupsResponseBodyAuthRuleGroupsRulesRuleItems : TeaModel {
                    [NameInMap("AuthRuleId")]
                    [Validation(Required=false)]
                    public long? AuthRuleId { get; set; }

                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

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
