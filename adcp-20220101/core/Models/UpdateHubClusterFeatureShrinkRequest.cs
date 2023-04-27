// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class UpdateHubClusterFeatureShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP.
        /// </summary>
        [NameInMap("ApiServerEipId")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        [NameInMap("ArgoCDEnabled")]
        [Validation(Required=false)]
        public bool? ArgoCDEnabled { get; set; }

        [NameInMap("ArgoServerEnabled")]
        [Validation(Required=false)]
        public bool? ArgoServerEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the audit logging feature. Valid values:
        /// 
        /// *   true: enables the audit logging feature.
        /// *   false: disables the audit logging feature.
        /// </summary>
        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the cluster. After you enable deletion protection, you cannot delete the master instance in the console or by calling the DeleteHubCluster operation. Valid values:
        /// 
        /// *   true: enables deletion protection for the cluster.
        /// *   false: disables deletion protection for the cluster. This is the default value.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to enable Alibaba Cloud Service Mesh (ASM). Valid values:
        /// 
        /// true: enables ASM. false: disables ASM.
        /// </summary>
        [NameInMap("EnableMesh")]
        [Validation(Required=false)]
        public bool? EnableMesh { get; set; }

        /// <summary>
        /// The name of the cluster. The name must be 1 to 63 characters in length. It must start with a letter, and can contain letters, digits, underscores (\_), and hyphens (-).
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
        /// Specifies whether to associate an elastic IP address (EIP) with the API server. Valid values:
        /// 
        /// *   true: associates an EIP with the API server. You can specify the ApiServerEipId parameter. If you do not specify the ApiServerEipId parameter, the system automatically creates an EIP.
        /// *   false: disassociates an EIP from the API server.
        /// </summary>
        [NameInMap("PublicApiServerEnabled")]
        [Validation(Required=false)]
        public bool? PublicApiServerEnabled { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitchesShrink { get; set; }

        [NameInMap("WorkflowScheduleMode")]
        [Validation(Required=false)]
        public string WorkflowScheduleMode { get; set; }

    }

}
