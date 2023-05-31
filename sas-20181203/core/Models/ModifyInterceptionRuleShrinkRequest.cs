// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyInterceptionRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~182997~~) operation to query the IDs of container clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The list of destination network objects.
        /// </summary>
        [NameInMap("DstTarget")]
        [Validation(Required=false)]
        public string DstTargetShrink { get; set; }

        /// <summary>
        /// The interception mode. Valid values:
        /// 
        /// *   **1**: block
        /// *   **2**: alert
        /// *   **3**: allow
        /// </summary>
        [NameInMap("InterceptType")]
        [Validation(Required=false)]
        public int? InterceptType { get; set; }

        /// <summary>
        /// The priority of the rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("OrderIndex")]
        [Validation(Required=false)]
        public long? OrderIndex { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Specifies whether the rule is enabled. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// The list of source network objects.
        /// </summary>
        [NameInMap("SrcTarget")]
        [Validation(Required=false)]
        public string SrcTargetShrink { get; set; }

    }

}
