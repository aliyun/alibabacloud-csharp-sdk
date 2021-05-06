// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CreateSchedruleOnDemandRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=true)]
        public string RuleName { get; set; }

        [NameInMap("RuleConditionMbps")]
        [Validation(Required=true)]
        public string RuleConditionMbps { get; set; }

        [NameInMap("RuleConditionKpps")]
        [Validation(Required=true)]
        public string RuleConditionKpps { get; set; }

        [NameInMap("RuleConditionCnt")]
        [Validation(Required=true)]
        public string RuleConditionCnt { get; set; }

        [NameInMap("RuleAction")]
        [Validation(Required=true)]
        public string RuleAction { get; set; }

        [NameInMap("RuleSwitch")]
        [Validation(Required=true)]
        public string RuleSwitch { get; set; }

        [NameInMap("RuleUndoMode")]
        [Validation(Required=true)]
        public string RuleUndoMode { get; set; }

        [NameInMap("RuleUndoBeginTime")]
        [Validation(Required=true)]
        public string RuleUndoBeginTime { get; set; }

        [NameInMap("RuleUndoEndTime")]
        [Validation(Required=false)]
        public string RuleUndoEndTime { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=true)]
        public string TimeZone { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
