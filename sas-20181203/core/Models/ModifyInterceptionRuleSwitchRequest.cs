// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyInterceptionRuleSwitchRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The IDs of the rules whose status you want to change. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the [ListInterceptionRulePage](~~182997~~) operation to query the IDs of rules.
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// Specifies whether the rule is enabled. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

    }

}
