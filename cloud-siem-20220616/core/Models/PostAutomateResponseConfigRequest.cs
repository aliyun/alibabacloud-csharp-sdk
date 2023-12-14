// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostAutomateResponseConfigRequest : TeaModel {
        /// <summary>
        /// The configuration of the action that is performed after the rule is hit. The value is in JSON format.
        /// </summary>
        [NameInMap("ActionConfig")]
        [Validation(Required=false)]
        public string ActionConfig { get; set; }

        /// <summary>
        /// The action that is performed after the rule is hit. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   doPlaybook: Execute a playbook.
        /// *   changeEventStatus: Change the event status.
        /// *   changeThreatLevel: Change the threat level of the event.
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The rule type. Valid values:
        /// 
        /// *   event
        /// *   alert
        /// </summary>
        [NameInMap("AutoResponseType")]
        [Validation(Required=false)]
        public string AutoResponseType { get; set; }

        /// <summary>
        /// The trigger condition of the rule. The value is in JSON format.
        /// </summary>
        [NameInMap("ExecutionCondition")]
        [Validation(Required=false)]
        public string ExecutionCondition { get; set; }

        /// <summary>
        /// The rule ID.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The rule name.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The ID of the user who created the rule.
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
