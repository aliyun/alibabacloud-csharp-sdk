// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class UpdateHubClusterFeatureShrinkRequest : TeaModel {
        /// <summary>
        /// The Internet access control list (ACL). This parameter takes effect only if PublicAccessEnabled is set to true.
        /// </summary>
        [NameInMap("AccessControlList")]
        [Validation(Required=false)]
        public string AccessControlListShrink { get; set; }

        /// <summary>
        /// The ID of the EIP.
        /// </summary>
        [NameInMap("ApiServerEipId")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// Specifies whether to enable Argo CD. This parameter takes effect only if Profile is set to XFlow. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ArgoCDEnabled")]
        [Validation(Required=false)]
        public bool? ArgoCDEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable high availability for Argo CD. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ArgoCDHAEnabled")]
        [Validation(Required=false)]
        public bool? ArgoCDHAEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable ArgoEvents. Valid values:
        /// 
        /// - true
        /// - false
        /// </summary>
        [NameInMap("ArgoEventsEnabled")]
        [Validation(Required=false)]
        public bool? ArgoEventsEnabled { get; set; }

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
        /// Specifies whether to enable the audit logging feature. Valid values:
        /// 
        /// *   true: enables the audit logging feature.
        /// *   false: disables the audit logging feature.
        /// </summary>
        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable the deletion protection feature for the cluster. After you enable the deletion protection feature for the cluster, you cannot delete the cluster in the console or by calling the DeleteHubCluster operation. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to enable Service Mesh (ASM). Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableMesh")]
        [Validation(Required=false)]
        public bool? EnableMesh { get; set; }

        /// <summary>
        /// Specifies whether to enable Gateway. Valid values:
        /// - true
        /// - false
        /// </summary>
        [NameInMap("GatewayEnabled")]
        [Validation(Required=false)]
        public bool? GatewayEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the monitoring dashboard feature for the workflow instance. This parameter takes effect only if Profile is set to XFlow. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("MonitorEnabled")]
        [Validation(Required=false)]
        public bool? MonitorEnabled { get; set; }

        /// <summary>
        /// The name of the master instance. The name must be 1 to 63 characters in length. It must start with a letter, and can contain letters, digits, underscores (_), and hyphens (-).
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
        /// Specifies whether to enable public domain name resolution in the Argo CD or Argo Workflow console. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("PublicAccessEnabled")]
        [Validation(Required=false)]
        public bool? PublicAccessEnabled { get; set; }

        /// <summary>
        /// Specifies whether to associate an elastic IP address (EIP) with the API server. Valid values:
        /// 
        /// *   true: associates an EIP with the API server. You can specify ApiServerEipId. If you do not specify ApiServerEipId, the system automatically creates an EIP.
        /// *   false: disassociates an EIP from the API server.
        /// </summary>
        [NameInMap("PublicApiServerEnabled")]
        [Validation(Required=false)]
        public bool? PublicApiServerEnabled { get; set; }

        /// <summary>
        /// The vSwitches.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitchesShrink { get; set; }

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
