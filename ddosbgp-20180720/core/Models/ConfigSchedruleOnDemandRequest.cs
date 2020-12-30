// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ConfigSchedruleOnDemandRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleConditionMbps")]
        [Validation(Required=false)]
        public string RuleConditionMbps { get; set; }

        [NameInMap("RuleConditionKpps")]
        [Validation(Required=false)]
        public string RuleConditionKpps { get; set; }

        [NameInMap("RuleConditionCnt")]
        [Validation(Required=false)]
        public string RuleConditionCnt { get; set; }

        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public string RuleSwitch { get; set; }

        [NameInMap("RuleUndoMode")]
        [Validation(Required=false)]
        public string RuleUndoMode { get; set; }

        [NameInMap("RuleUndoBeginTime")]
        [Validation(Required=false)]
        public string RuleUndoBeginTime { get; set; }

        [NameInMap("RuleUndoEndTime")]
        [Validation(Required=false)]
        public string RuleUndoEndTime { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
