// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterRequest : TeaModel {
        /// <summary>
        /// The network access control lists (ACLs) of the SLB instance associated with the API server if the cluster is a registered cluster.
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// The custom subject alternative names (SANs) for the API server certificate to accept requests from specified IP addresses or domain names. This parameter is available only for ACK managed clusters.
        /// </summary>
        [NameInMap("api_server_custom_cert_sans")]
        [Validation(Required=false)]
        public ModifyClusterRequestApiServerCustomCertSans ApiServerCustomCertSans { get; set; }
        public class ModifyClusterRequestApiServerCustomCertSans : TeaModel {
            /// <summary>
            /// Specifies whether to overwrite or add SANs. Valid values:
            /// 
            /// *   overwrite: overwrites SANs.
            /// *   append: adds SANs.
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The SANs.
            /// </summary>
            [NameInMap("subject_alternative_names")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeNames { get; set; }

        }

        /// <summary>
        /// Specifies whether to associate an elastic IP address (EIP) with the cluster. This EIP is used to enable access to the API server over the Internet. Valid values:
        /// 
        /// *   `true`: associates an EIP with the cluster.
        /// *   `false`: does not associate an EIP with the cluster.
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// The ID of the EIP that you want to associate with the API server of the cluster. This parameter takes effect when `api_server_eip` is set to `true`.
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// 
        /// The cluster name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The cluster name cannot start with a hyphen (-).
        /// </summary>
        [NameInMap("cluster_name")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies whether to enable cluster deletion protection. If you enable this option, the cluster cannot be deleted in the console or by calling API operations. Valid values:
        /// 
        /// *   `true`: enables cluster deletion protection.
        /// *   `false`: disables cluster deletion protection.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to enable the RAM Roles for Service Accounts (RRSA) feature. This parameter is available only for ACK managed clusters. Valid values:
        /// 
        /// *   `true`: enables the RRSA feature.
        /// *   `false`: disables the RRSA feature.
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        /// <summary>
        /// Specifies whether to remap the test domain name of the cluster. Valid values:
        /// 
        /// *   `true`: remaps the test domain name of the cluster.
        /// *   `false`: does not remap the test domain name of the cluster.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ingress_domain_rebinding")]
        [Validation(Required=false)]
        public bool? IngressDomainRebinding { get; set; }

        /// <summary>
        /// The ID of the Server Load Balancer (SLB) instance of the cluster to be modified.
        /// </summary>
        [NameInMap("ingress_loadbalancer_id")]
        [Validation(Required=false)]
        public string IngressLoadbalancerId { get; set; }

        /// <summary>
        /// Specifies whether to enable instance deletion protection. If you enable this option, the instance cannot be deleted in the console or by calling API operations. Valid values:
        /// 
        /// *   `true`: enables instance deletion protection.
        /// *   `false`: disables instance deletion protection.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("instance_deletion_protection")]
        [Validation(Required=false)]
        public bool? InstanceDeletionProtection { get; set; }

        /// <summary>
        /// The cluster maintenance window. This feature takes effect only for ACK Pro clusters.
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// The automatic O\\&M policy of the cluster.
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public ModifyClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class ModifyClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// The configurations of auto cluster update.
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public ModifyClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class ModifyClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// The frequency of auto cluster updates. Valid values:
                /// 
                /// *   patch
                /// *   stable
                /// *   rapid
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// Specifies whether to enable auto cluster update.
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

        /// <summary>
        /// The cluster resource group ID.
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The storage configurations of system events.
        /// </summary>
        [NameInMap("system_events_logging")]
        [Validation(Required=false)]
        public ModifyClusterRequestSystemEventsLogging SystemEventsLogging { get; set; }
        public class ModifyClusterRequestSystemEventsLogging : TeaModel {
            /// <summary>
            /// Specifies whether to enable system event storage.
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The name of the Simple Log Service project that stores system events.
            /// </summary>
            [NameInMap("logging_project")]
            [Validation(Required=false)]
            public string LoggingProject { get; set; }

        }

    }

}
