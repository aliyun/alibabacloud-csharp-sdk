// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class CreateHubClusterShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to use a public IP address to expose the API server. Valid values: - true: uses a public IP address to expose the API server. - true: uses an internal IP address to expose the API server.
        /// </summary>
        [NameInMap("ApiServerPublicEip")]
        [Validation(Required=false)]
        public bool? ApiServerPublicEip { get; set; }

        /// <summary>
        /// Specifies whether to enable audit logs. Valid values: - true: enables audit logs. - false: disables audit logs.
        /// </summary>
        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        [NameInMap("ClusterConfiguration")]
        [Validation(Required=false)]
        public string ClusterConfigurationShrink { get; set; }

        /// <summary>
        /// Specifies whether the security group is an advanced security group.
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
        /// Scenario-oriented master control type. The value can be:
        /// 
        /// - `Default`: Standard scenario Master instance.
        /// - `XFlow`: Workflow scenario master instance.
        /// 
        /// Default Value: `Default`.
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// The ID of the region. You can call the DescribeRegions operation to query available regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitches { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the master instance belongs. You can call the DescribeVpcs operation to query available VPCs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
