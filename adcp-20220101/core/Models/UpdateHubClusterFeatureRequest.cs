// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class UpdateHubClusterFeatureRequest : TeaModel {
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
        /// Specifies whether to enable audit logs. Valid values: - true: enable audit logs. - false: disables audit logs.
        /// </summary>
        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        /// <summary>
        /// The ID of the master instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the master instance. After you enable deletion protection, you cannot delete the master instance in the console or by calling API operations. Valid values:
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to enable Service Mesh (ASM). Valid values: true: enables ASM. false: disables ASM.
        /// </summary>
        [NameInMap("EnableMesh")]
        [Validation(Required=false)]
        public bool? EnableMesh { get; set; }

        /// <summary>
        /// The name of the master instance. The name must be 1 to 63 characters in length, and can contain letters and digits. The name must start with a letter. The name can contain letters, digits, underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PriceLimit")]
        [Validation(Required=false)]
        public string PriceLimit { get; set; }

        /// <summary>
        /// Specifies whether to associate an elastic IP address (EIP) with the API server. Default value: false. To associate an EIP with the API server, set the value to true. You can use a custom EIP by setting the ApiServerEipId parameter. If you do not set the ApiServerEipId parameter, the system automatically creates an EIP.
        /// </summary>
        [NameInMap("PublicApiServerEnabled")]
        [Validation(Required=false)]
        public bool? PublicApiServerEnabled { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<string> VSwitches { get; set; }

        [NameInMap("WorkflowScheduleMode")]
        [Validation(Required=false)]
        public string WorkflowScheduleMode { get; set; }

    }

}
