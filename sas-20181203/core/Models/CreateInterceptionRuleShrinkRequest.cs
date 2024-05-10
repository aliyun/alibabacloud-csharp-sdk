// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateInterceptionRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The information about the destination network object. The value of this parameter contains the following fields:
        /// 
        /// *   targetId: the ID of the destination network object. You can call the [ListInterceptionTargetPage](~~ListInterceptionTargetPage~~) operation to query the ID.
        /// *   ports: the destination port ranges.
        /// </summary>
        [NameInMap("DstTargetList")]
        [Validation(Required=false)]
        public string DstTargetListShrink { get; set; }

        /// <summary>
        /// The action on traffic. Valid values:
        /// 
        /// *   **1**: blocks traffic.
        /// *   **2**: allows traffic and generates alerts.
        /// *   **3**: allows traffic and does not generate alerts.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InterceptType")]
        [Validation(Required=false)]
        public long? InterceptType { get; set; }

        /// <summary>
        /// The priority of the defense rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderIndex")]
        [Validation(Required=false)]
        public long? OrderIndex { get; set; }

        /// <summary>
        /// The name of the defense rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Specifies the status of the defense rule. Valid values:
        /// 
        /// *   **0**: disables the rule.
        /// *   **1**: enables the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// The type of the defense rule. Valid values:
        /// 
        /// *   customize: custom rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// The source network object. The value of this parameter contains the following field:
        /// 
        /// *   targetId: the ID of the source network object. You can call the [ListInterceptionTargetPage](~~ListInterceptionTargetPage~~) operation to query the ID.
        /// </summary>
        [NameInMap("SrcTarget")]
        [Validation(Required=false)]
        public string SrcTargetShrink { get; set; }

    }

}
