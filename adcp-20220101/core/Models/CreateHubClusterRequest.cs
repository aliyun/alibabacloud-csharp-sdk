// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class CreateHubClusterRequest : TeaModel {
        /// <summary>
        /// Specifies whether to expose the API server to the Internet. Valid values:
        /// 
        /// *   true: exposes the API server to the Internet.
        /// *   false: exposes the API server to the internal network.
        /// </summary>
        [NameInMap("ApiServerPublicEip")]
        [Validation(Required=false)]
        public bool? ApiServerPublicEip { get; set; }

        /// <summary>
        /// Specifies whether to enable the workflow instance UI. This parameter takes effect only if Profile is set to XFlow. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ArgoServerEnabled")]
        [Validation(Required=false)]
        public bool? ArgoServerEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the audit log feature. Valid values:
        /// 
        /// *   true: enables the audit log feature.
        /// *   false: disables the audit log feature.
        /// </summary>
        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        /// <summary>
        /// Specifies whether to use an advanced security group.
        /// </summary>
        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// The name of the master instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The limit on the prices of containers in the workflow. This parameter takes effect only if the WorkflowScheduleMode parameter is set to cost-optimized.
        /// </summary>
        [NameInMap("PriceLimit")]
        [Validation(Required=false)]
        public string PriceLimit { get; set; }

        /// <summary>
        /// The type of scenario for which the master instance is suitable. Valid values:
        /// 
        /// *   `Default`: The master instance is suitable for standard scenarios.
        /// *   `XFlow`: The master instance is suitable for workflow scenarios.
        /// 
        /// Default value: `Default`.
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// The ID of the region. You can call the DescribeRegions operation to query available regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The Resource Group ID.
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// The tags.
        /// 
        /// You can specify at most 20 tags in each call.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<Tag> Tag { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitches { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the master instance belongs. You can call the DescribeVpcs operation to query available VPCs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The scheduling mode of the workflow. This parameter takes effect only if Profile is set to XFlow. Valid values:
        /// 
        /// *   cost-optimized: cost-prioritized scheduling mode.
        /// *   stock-optimized: inventory-prioritized scheduling mode.
        /// </summary>
        [NameInMap("WorkflowScheduleMode")]
        [Validation(Required=false)]
        public string WorkflowScheduleMode { get; set; }

    }

}
