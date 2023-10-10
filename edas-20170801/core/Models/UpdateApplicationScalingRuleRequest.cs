// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see [ListApplication](~~149390~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The behavior of the auto scaling. See the example for the data structure.
        /// </summary>
        [NameInMap("ScalingBehaviour")]
        [Validation(Required=false)]
        public string ScalingBehaviour { get; set; }

        /// <summary>
        /// Specifies whether to enable the auto scaling policy. Valid values:
        /// 
        /// *   **true**: enables the auto scaling policy.
        /// *   **false**: disables the auto scaling policy.
        /// </summary>
        [NameInMap("ScalingRuleEnable")]
        [Validation(Required=false)]
        public bool? ScalingRuleEnable { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// The name of the auto scaling policy.
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("ScalingRuleTimer")]
        [Validation(Required=false)]
        public string ScalingRuleTimer { get; set; }

        /// <summary>
        /// The trigger policy for the auto scaling policy. Set this parameter in the JSON format by using the ScalingRuleTriggerDTO class. For more information, see Additional description of request parameters.
        /// </summary>
        [NameInMap("ScalingRuleTrigger")]
        [Validation(Required=false)]
        public string ScalingRuleTrigger { get; set; }

        /// <summary>
        /// The type of the auto scaling policy.
        /// 
        /// *   Set the value to trigger.
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
