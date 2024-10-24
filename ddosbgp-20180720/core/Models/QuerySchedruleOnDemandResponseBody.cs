// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class QuerySchedruleOnDemandResponseBody : TeaModel {
        /// <summary>
        /// The ID of the on-demand instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of the scheduling rule.
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public List<QuerySchedruleOnDemandResponseBodyRuleConfig> RuleConfig { get; set; }
        public class QuerySchedruleOnDemandResponseBodyRuleConfig : TeaModel {
            /// <summary>
            /// The scheduling action. The value is set to **declare**, which indicates that the route is advertised.
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// If the inbound bandwidth or packets consecutively exceed the threshold for the specified number of times, the scheduling rule is triggered and traffic is rerouted to the on-demand instance. The specified number of times is the value of this parameter.
            /// 
            /// >  The threshold of inbound bandwidth is the value of **RuleConditionMbps**. The threshold of inbound packets is the value of **RuleConditionKpps**.
            /// </summary>
            [NameInMap("RuleConditionCnt")]
            [Validation(Required=false)]
            public string RuleConditionCnt { get; set; }

            /// <summary>
            /// The threshold of inbound packets. Unit: kilo packets per second (Kpps). Minimum value: **10**.
            /// </summary>
            [NameInMap("RuleConditionKpps")]
            [Validation(Required=false)]
            public string RuleConditionKpps { get; set; }

            /// <summary>
            /// The threshold of inbound bandwidth. Unit: Mbit/s. Minimum value: **100**.
            /// </summary>
            [NameInMap("RuleConditionMbps")]
            [Validation(Required=false)]
            public string RuleConditionMbps { get; set; }

            /// <summary>
            /// The name of the scheduling rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// Indicates whether the scheduling rule is enabled. Valid values:
            /// 
            /// *   **on**: enabled.
            /// *   **off**: disabled.
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public string RuleSwitch { get; set; }

            /// <summary>
            /// The start time of the period during which the scheduling rule is automatically stopped. The time must be in the 24-hour clock and in the `hh:mm` format.
            /// 
            /// If the system detects that DDoS attacks stop, the system no longer reroutes traffic to the on-demand instance from the time you specified. We recommend that you set this parameter to a value that is defined as off-peak hours.
            /// 
            /// >  This parameter takes effect only when the value of **RuleUndoMode** is **auto**.
            /// </summary>
            [NameInMap("RuleUndoBeginTime")]
            [Validation(Required=false)]
            public string RuleUndoBeginTime { get; set; }

            /// <summary>
            /// The end time of the period during which the scheduling rule is automatically stopped. The time must be in the 24-hour clock and in the `hh:mm` format.
            /// </summary>
            [NameInMap("RuleUndoEndTime")]
            [Validation(Required=false)]
            public string RuleUndoEndTime { get; set; }

            /// <summary>
            /// The stop method of the scheduling rule. Valid values:
            /// 
            /// *   **auto**
            /// *   **manual**
            /// </summary>
            [NameInMap("RuleUndoMode")]
            [Validation(Required=false)]
            public string RuleUndoMode { get; set; }

            /// <summary>
            /// The time zone of the time when the scheduling rule automatically stops. The time zone must be in the `GMT-hh:mm` format.
            /// 
            /// For example, the value `GMT-08:00` indicates that the time zone is UTC+8.
            /// 
            /// >  This parameter takes effect only when the value of **RuleUndoMode** is **auto**.
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// The status of the scheduling rule.
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public List<QuerySchedruleOnDemandResponseBodyRuleStatus> RuleStatus { get; set; }
        public class QuerySchedruleOnDemandResponseBodyRuleStatus : TeaModel {
            /// <summary>
            /// The CIDR block of the on-demand instance.
            /// </summary>
            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

            /// <summary>
            /// The scheduling status. Valid values:
            /// 
            /// *   **scheduled**
            /// *   **unscheduled**
            /// </summary>
            [NameInMap("RuleSchedStatus")]
            [Validation(Required=false)]
            public string RuleSchedStatus { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
