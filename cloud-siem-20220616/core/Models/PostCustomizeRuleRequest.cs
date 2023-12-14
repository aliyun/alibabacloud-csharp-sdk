// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostCustomizeRuleRequest : TeaModel {
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
        /// The extended information about event generation. If eventTransferType is set to allToSingle, the value of this parameter indicates the length and unit of the alert aggregation window.
        /// </summary>
        [NameInMap("EventTransferExt")]
        [Validation(Required=false)]
        public string EventTransferExt { get; set; }

        /// <summary>
        /// Specifies whether to convert an alert to an event. Valid values:
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
        /// The ID of the rule.
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
        /// The window length of the rule.
        /// </summary>
        [NameInMap("QueryCycle")]
        [Validation(Required=false)]
        public string QueryCycle { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The query condition of the rule. The value is in the JSON format.
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
        /// The log aggregation field of the rule. The value is a JSON string.
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
        /// The threshold configuration of the rule. The value is in the JSON format.
        /// </summary>
        [NameInMap("RuleThreshold")]
        [Validation(Required=false)]
        public string RuleThreshold { get; set; }

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

}
