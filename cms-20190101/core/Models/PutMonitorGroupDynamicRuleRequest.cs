// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitorGroupDynamicRuleRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupRules")]
        [Validation(Required=false)]
        public List<PutMonitorGroupDynamicRuleRequestGroupRules> GroupRules { get; set; }
        public class PutMonitorGroupDynamicRuleRequestGroupRules : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("FilterRelation")]
            [Validation(Required=false)]
            public string FilterRelation { get; set; }

            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<PutMonitorGroupDynamicRuleRequestGroupRulesFilters> Filters { get; set; }
            public class PutMonitorGroupDynamicRuleRequestGroupRulesFilters : TeaModel {
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
