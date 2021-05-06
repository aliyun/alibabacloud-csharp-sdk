// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class QuerySchedruleOnDemandResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=true)]
        public string UserId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("RuleConfig")]
        [Validation(Required=true)]
        public List<QuerySchedruleOnDemandResponseRuleConfig> RuleConfig { get; set; }
        public class QuerySchedruleOnDemandResponseRuleConfig : TeaModel {
            [NameInMap("RuleName")]
            [Validation(Required=true)]
            public string RuleName { get; set; }

            [NameInMap("RuleConditionCnt")]
            [Validation(Required=true)]
            public string RuleConditionCnt { get; set; }

            [NameInMap("RuleUndoBeginTime")]
            [Validation(Required=true)]
            public string RuleUndoBeginTime { get; set; }

            [NameInMap("RuleUndoMode")]
            [Validation(Required=true)]
            public string RuleUndoMode { get; set; }

            [NameInMap("RuleUndoEndTime")]
            [Validation(Required=true)]
            public string RuleUndoEndTime { get; set; }

            [NameInMap("RuleConditionMbps")]
            [Validation(Required=true)]
            public string RuleConditionMbps { get; set; }

            [NameInMap("RuleConditionKpps")]
            [Validation(Required=true)]
            public string RuleConditionKpps { get; set; }

            [NameInMap("RuleSwitch")]
            [Validation(Required=true)]
            public string RuleSwitch { get; set; }

            [NameInMap("RuleAction")]
            [Validation(Required=true)]
            public string RuleAction { get; set; }

            [NameInMap("TimeZone")]
            [Validation(Required=true)]
            public string TimeZone { get; set; }

        }

        [NameInMap("RuleStatus")]
        [Validation(Required=true)]
        public List<QuerySchedruleOnDemandResponseRuleStatus> RuleStatus { get; set; }
        public class QuerySchedruleOnDemandResponseRuleStatus : TeaModel {
            [NameInMap("Net")]
            [Validation(Required=true)]
            public string Net { get; set; }

            [NameInMap("RuleSchedStatus")]
            [Validation(Required=true)]
            public string RuleSchedStatus { get; set; }

        }

    }

}
