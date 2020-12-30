// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class QuerySchedruleOnDemandResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public List<QuerySchedruleOnDemandResponseBodyRuleStatus> RuleStatus { get; set; }
        public class QuerySchedruleOnDemandResponseBodyRuleStatus : TeaModel {
            [NameInMap("RuleSchedStatus")]
            [Validation(Required=false)]
            public string RuleSchedStatus { get; set; }

            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

        }

        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public List<QuerySchedruleOnDemandResponseBodyRuleConfig> RuleConfig { get; set; }
        public class QuerySchedruleOnDemandResponseBodyRuleConfig : TeaModel {
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public string RuleSwitch { get; set; }

            [NameInMap("RuleConditionMbps")]
            [Validation(Required=false)]
            public string RuleConditionMbps { get; set; }

            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            [NameInMap("RuleConditionKpps")]
            [Validation(Required=false)]
            public string RuleConditionKpps { get; set; }

            [NameInMap("RuleUndoMode")]
            [Validation(Required=false)]
            public string RuleUndoMode { get; set; }

            [NameInMap("RuleUndoBeginTime")]
            [Validation(Required=false)]
            public string RuleUndoBeginTime { get; set; }

            [NameInMap("RuleConditionCnt")]
            [Validation(Required=false)]
            public string RuleConditionCnt { get; set; }

            [NameInMap("RuleUndoEndTime")]
            [Validation(Required=false)]
            public string RuleUndoEndTime { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
