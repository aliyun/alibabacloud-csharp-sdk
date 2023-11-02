// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleRequest : TeaModel {
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        [NameInMap("AlertTypeMds")]
        [Validation(Required=false)]
        public string AlertTypeMds { get; set; }

        [NameInMap("EventTransferExt")]
        [Validation(Required=false)]
        public string EventTransferExt { get; set; }

        [NameInMap("EventTransferSwitch")]
        [Validation(Required=false)]
        public int? EventTransferSwitch { get; set; }

        [NameInMap("EventTransferType")]
        [Validation(Required=false)]
        public string EventTransferType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        [NameInMap("LogSourceMds")]
        [Validation(Required=false)]
        public string LogSourceMds { get; set; }

        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("LogTypeMds")]
        [Validation(Required=false)]
        public string LogTypeMds { get; set; }

        [NameInMap("QueryCycle")]
        [Validation(Required=false)]
        public string QueryCycle { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RuleCondition")]
        [Validation(Required=false)]
        public string RuleCondition { get; set; }

        [NameInMap("RuleDesc")]
        [Validation(Required=false)]
        public string RuleDesc { get; set; }

        [NameInMap("RuleGroup")]
        [Validation(Required=false)]
        public string RuleGroup { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleThreshold")]
        [Validation(Required=false)]
        public string RuleThreshold { get; set; }

        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public string ThreatLevel { get; set; }

    }

}
