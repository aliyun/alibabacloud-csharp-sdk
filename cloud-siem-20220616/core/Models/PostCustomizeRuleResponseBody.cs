// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PostCustomizeRuleResponseBodyData Data { get; set; }
        public class PostCustomizeRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The risk type.
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// The internal code of the risk type.
            /// </summary>
            [NameInMap("AlertTypeMds")]
            [Validation(Required=false)]
            public string AlertTypeMds { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }

            [NameInMap("AttCk")]
            [Validation(Required=false)]
            public string AttCk { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// The extended information about event generation. If eventTransferType is set to allToSingle, the value of this parameter indicates the length and unit of the alert aggregation window. The HTML escape characters are reversed.
            /// </summary>
            [NameInMap("EventTransferExt")]
            [Validation(Required=false)]
            public string EventTransferExt { get; set; }

            /// <summary>
            /// Indicates whether the system generates an event for the alert. Valid values:
            /// 
            /// *   0: no
            /// *   1: yes
            /// </summary>
            [NameInMap("EventTransferSwitch")]
            [Validation(Required=false)]
            public int? EventTransferSwitch { get; set; }

            /// <summary>
            /// The event generation method. Valid values:
            /// 
            /// *   default: The default method is used.
            /// *   singleToSingle: The system generates an event for each alert.
            /// *   allToSingle: The system generates an event for alerts within a period of time.
            /// </summary>
            [NameInMap("EventTransferType")]
            [Validation(Required=false)]
            public string EventTransferType { get; set; }

            /// <summary>
            /// The time when the custom rule was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the custom rule was last updated.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the custom rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The log source of the rule.
            /// </summary>
            [NameInMap("LogSource")]
            [Validation(Required=false)]
            public string LogSource { get; set; }

            /// <summary>
            /// The internal code of the log source.
            /// </summary>
            [NameInMap("LogSourceMds")]
            [Validation(Required=false)]
            public string LogSourceMds { get; set; }

            /// <summary>
            /// The log type of the rule.
            /// </summary>
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            /// <summary>
            /// The internal code of the log type.
            /// </summary>
            [NameInMap("LogTypeMds")]
            [Validation(Required=false)]
            public string LogTypeMds { get; set; }

            /// <summary>
            /// The window length of the rule. The HTML escape characters are reversed.
            /// </summary>
            [NameInMap("QueryCycle")]
            [Validation(Required=false)]
            public string QueryCycle { get; set; }

            /// <summary>
            /// The query condition of the rule. The value is in the JSON format. The HTML escape characters are reversed.
            /// </summary>
            [NameInMap("RuleCondition")]
            [Validation(Required=false)]
            public string RuleCondition { get; set; }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// The log aggregation field of the rule. The value is a JSON string. The HTML escape characters are reversed.
            /// </summary>
            [NameInMap("RuleGroup")]
            [Validation(Required=false)]
            public string RuleGroup { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The threshold configuration of the rule. The value is in the JSON format. The HTML escape characters are reversed.
            /// </summary>
            [NameInMap("RuleThreshold")]
            [Validation(Required=false)]
            public string RuleThreshold { get; set; }

            /// <summary>
            /// The type of the rule. Valid values:
            /// 
            /// *   predefine
            /// *   customize
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// The rule status. Valid values:
            /// 
            /// *   0: The rule is in the initial state.
            /// *   10: The simulation data is tested.
            /// *   15: The business data is being tested.
            /// *   20: The business data test ends.
            /// *   100: The rule takes effect.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   serious: high
            /// *   suspicious: medium
            /// *   remind: low
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
