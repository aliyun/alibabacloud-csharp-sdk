// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCustomizeRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomizeRuleResponseBodyData Data { get; set; }
        public class DescribeCustomizeRuleResponseBodyData : TeaModel {
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            [NameInMap("AlertTypeMds")]
            [Validation(Required=false)]
            public string AlertTypeMds { get; set; }

            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }

            [NameInMap("EventTransferExt")]
            [Validation(Required=false)]
            public string EventTransferExt { get; set; }

            [NameInMap("EventTransferSwitch")]
            [Validation(Required=false)]
            public int? EventTransferSwitch { get; set; }

            [NameInMap("EventTransferType")]
            [Validation(Required=false)]
            public string EventTransferType { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

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

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
