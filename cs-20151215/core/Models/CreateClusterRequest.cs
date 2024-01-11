// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// The network access control list (ACL) of the SLB instance associated with the API server if the cluster is a registered cluster.
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// The components that you want to install in the cluster. When you create a cluster, you can set the `addons` parameter to install specific components.
        /// 
        /// **Network plug-in**: required. The Flannel and Terway plug-ins are supported. Select one of the plug-ins for the cluster.
        /// 
        /// *   Specify the Flannel plug-in in the following format: \[{"name":"flannel","config":""}].
        /// *   Specify the Terway plug-in in the following format: \[{"name": "terway-eniip","config": ""}].
        /// 
        /// **Volume plug-in**: required. The `CSI` and `FlexVolume` volume plug-ins are supported.
        /// 
        /// *   Specify the `CSI` plug-in in the following format: \[{"name":"csi-plugin","config": ""},{"name": "csi-provisioner","config": ""}].
        /// *   Specify the `FlexVolume` plug-in in the following format: \[{"name": "flexvolume","config": ""}].
        /// 
        /// **Simple Log Service component**: optional. We recommend that you enable Simple Log Service. If Simple Log Service is disabled, you cannot use the cluster auditing feature.
        /// 
        /// *   Use an existing `Simple Log Service project`: \[{"name": "logtail-ds","config": "{"IngressDashboardEnabled":"true","sls_project_name":"your_sls_project_name"}"}].
        /// *   To create a `Simple Log Service project`, specify the component in the following format: \[{"name": "logtail-ds","config": "{"IngressDashboardEnabled":"true"}"}].
        /// 
        /// **Ingress controller**: optional. By default, the `nginx-ingress-controller` component is installed in ACK dedicated clusters.
        /// 
        /// *   To install nginx-ingress-controller and enable Internet access, specify the Ingress controller in the following format: \[{"name":"nginx-ingress-controller","config":"{"IngressSlbNetworkType":"internet"}"}].
        /// *   If you do not want to install nginx-ingress-controller, specify the component in the following format: \[{"name": "nginx-ingress-controller","config": "","disabled": true}].
        /// 
        /// **Event center**: optional. By default, the event center feature is enabled.
        /// 
        /// You can use Kubernetes event centers to store and query events, and configure alert rules. You can use the Logstores that are associated with Kubernetes event centers for free within 90 days. For more information, see [Create and use an event center](https://help.aliyun.com/document_detail/150476.html#task-2389213).
        /// 
        /// Enable the ack-node-problem-detector component in the following format: \[{"name":"ack-node-problem-detector","config":"{"sls_project_name":"your_sls_project_name"}"}].
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// Service accounts provide identities for pods when pods communicate with the `API server` of the cluster. `api-audiences` are used by the `API server` to check whether the `tokens` of requests are legitimate.`` Separate multiple `audiences` with commas (,).
        /// 
        /// For more information about `ServiceAccount`, see [Enable service account token volume projection](~~160384~~).
        /// </summary>
        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        /// <summary>
        /// The billing method of the cluster.
        /// </summary>
        [NameInMap("charge_type")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// Specifies whether to enable Center for Internet Security (CIS) reinforcement. For more information, see [CIS reinforcement](~~223744~~).
        /// 
        /// Valid values:
        /// 
        /// *   `true`: enables CIS reinforcement.
        /// *   `false`: disables CIS reinforcement.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("cis_enabled")]
        [Validation(Required=false)]
        public bool? CisEnabled { get; set; }

        /// <summary>
        /// Specifies whether to install the CloudMonitor agent. Valid values:
        /// 
        /// *   `true`: installs the CloudMonitor agent.
        /// *   `false`: does not install the CloudMonitor agent.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// The domain name of the cluster.
        /// 
        /// The domain name can contain one or more parts that are separated by periods (.). Each part cannot exceed 63 characters in length, and can contain lowercase letters, digits, and hyphens (-). Each part must start and end with a lowercase letter or digit.
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// The type of ACK managed cluster. Valid values:
        /// 
        /// *   `ack.pro.small`: ACK Pro cluster.
        /// *   `ack.standard`: ACK Basic cluster.
        /// 
        /// Default value: `ack.standard`. If you leave this property empty, an ACK Basic cluster.is created.
        /// 
        /// For more information, see [Overview of ACK Pro clusters](~~173290~~).
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// The cluster type. Valid value: ManagedKubernetes. 
        /// You can create ACK managed clusters, ACK Serverless clusters, and ACK Edge clusters.
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The CIDR block of pods. You can specify 10.0.0.0/8, 172.16-31.0.0/12-16, 192.168.0.0/16, or their subnets as the CIDR block of pods. The CIDR block of pods cannot overlap with the CIDR block of the VPC in which the cluster is deployed and the CIDR blocks of existing clusters in the VPC. You cannot modify the pod CIDR block after the cluster is created.
        /// 
        /// For more information about subnetting for ACK clusters, see [Plan CIDR blocks for an ACK cluster that is deployed in a VPC](~~86500~~).
        /// 
        /// >  This parameter is required if the cluster uses the Flannel plug-in.
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// The list of control plane components for which you want to enable log collection.
        /// 
        /// By default, the logs of kube-apiserver, kube-controller-manager, and kube-scheduler are collected.
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// The Simple Log Service project that is used to store the logs of control plane components. You can use an existing project or create one. If you choose to create a Simple Log Service project, the created project is named in the `k8s-log-{ClusterID}` format.
        /// </summary>
        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        /// <summary>
        /// The retention period of control plane logs in days.
        /// </summary>
        [NameInMap("controlplane_log_ttl")]
        [Validation(Required=false)]
        public string ControlplaneLogTtl { get; set; }

        /// <summary>
        /// The CPU management policy of the nodes in a node pool. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later.
        /// 
        /// *   `static`: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.
        /// *   `none`: specifies that the default CPU affinity is used.
        /// 
        /// Default value: `none`.
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// Specifies custom subject alternative names (SANs) for the API server certificate to accept requests from specified IP addresses or domain names. Multiple IP addresses and domain names are separated by commas (,).
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        public string CustomSan { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the cluster. If deletion protection is enabled, the cluster cannot be deleted in the ACK console or by calling API operations. Valid values:
        /// 
        /// *   `true`: enables deletion protection for the cluster. This way, the cluster cannot be deleted in the ACK console or by calling API operations.
        /// *   `false`: disables deletion protection for the cluster. This way, the cluster can be deleted in the ACK console or by calling API operations.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to perform a rollback if the cluster fails to be created. Valid values:
        /// 
        /// *   `true`: performs a rollback if the system fails to create the cluster.
        /// *   `false`: does not perform a rollback if the system fails to create the cluster.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// Specifies whether to enable the RAM Roles for Service Accounts (RRSA) feature.
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        /// <summary>
        /// The ID of a key that is managed by Key Management Service (KMS). The key is used to encrypt data disks. For more information, see [KMS](~~28935~~).
        /// 
        /// >  This feature supports only ACK Pro clusters.
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access for the cluster. You can use an elastic IP address (EIP) to expose the API server. This way, you can access the cluster over the Internet.
        /// 
        /// *   `true`: enables Internet access.
        /// *   `false`: disables Internet access. If you set this parameter to false, the API server cannot be accessed over the Internet.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("endpoint_public_access")]
        [Validation(Required=false)]
        public bool? EndpointPublicAccess { get; set; }

        /// <summary>
        /// Specifies whether to mount a data disk to a node that is created based on an existing ECS instance. Valid values:
        /// 
        /// *   `true`: stores the data of containers and images on a data disk. Back up the existing data on the data disk first.
        /// *   `false`: does not store the data of containers and images on a data disk.
        /// 
        /// Default value: `false`.
        /// 
        /// How to mount a data disk:
        /// 
        /// *   If an ECS instance has data disks mounted and the file system of the last data disk is not initialized, the system automatically formats the data disk to ext4. Then, the system mounts the data disk to /var/lib/docker and /var/lib/kubelet.
        /// *   If no data disk is attached to the ECS instances, the system does not purchase a new data disk.
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// Specifies a custom image for nodes. By default, the image provided by ACK is used. You can select a custom image to replace the default image. For more information, see [Custom images](~~146647~~).
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of OS distribution that you want to use. To specify the node OS, we recommend that you use this parameter. Valid values:
        /// 
        /// *   CentOS
        /// *   AliyunLinux
        /// *   AliyunLinux Qboot
        /// *   AliyunLinuxUEFI
        /// *   AliyunLinux3
        /// *   Windows
        /// *   WindowsCore
        /// *   AliyunLinux3Arm64
        /// *   ContainerOS
        /// 
        /// Default value: `CentOS`.
        /// </summary>
        [NameInMap("image_type")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The list of existing ECS instances that are specified as worker nodes for the cluster.
        /// 
        /// >  This parameter is required when you create worker nodes on existing ECS instances.
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// The cluster IP stack.
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// Specifies whether to create an advanced security group. This parameter takes effect only if `security_group_id` is left empty.
        /// 
        /// >  To use a basic security group, make sure that the sum of the number of nodes in the cluster and the number of pods that use Terway does not exceed 2,000. Therefore, if the cluster uses Terway, we recommend that you use an advanced security group.
        /// 
        /// *   `true`: creates an advanced security group.
        /// *   `false`: does not create an advanced security group.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("is_enterprise_security_group")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// Specifies whether to retain the names of existing ECS instances that are used in the cluster. Valid values:
        /// 
        /// *   `true`: retains the names.
        /// *   `false`: does not retain the names. The new names are assigned by the system.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// The name of the key pair. You must set this parameter or the `login_password` parameter.
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// The Kubernetes version of the cluster. The Kubernetes versions supported by ACK are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not set this parameter, the latest Kubernetes version is used.
        /// 
        /// You can create clusters of the latest two Kubernetes versions in the ACK console. You can create clusters of earlier Kubernetes versions by calling API operations. For more information about the Kubernetes versions supported by ACK, see [Release notes on Kubernetes versions](~~185269~~).
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// The specification of the Server Load Balancer (SLB) instance. Valid values:
        /// 
        /// *   slb.s1.small
        /// *   slb.s2.small
        /// *   slb.s2.medium
        /// *   slb.s3.small
        /// *   slb.s3.medium
        /// *   slb.s3.large
        /// 
        /// Default value: `slb.s2.small`.
        /// </summary>
        [NameInMap("load_balancer_spec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// Specifies whether to enable Simple Log Service for the cluster. Set the value to `SLS`. This parameter takes effect only for ACK Serverless clusters.
        /// </summary>
        [NameInMap("logging_type")]
        [Validation(Required=false)]
        public string LoggingType { get; set; }

        /// <summary>
        /// The password for SSH logon. You must set this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for master nodes. This parameter takes effect only if `master_instance_charge_type` is set to `PrePaid`. Valid values:
        /// 
        /// *   `true`: enables auto-renewal.
        /// *   `false`: disables auto-renewal.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("master_auto_renew")]
        [Validation(Required=false)]
        public bool? MasterAutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period for master nodes after the subscriptions of master nodes expire. This parameter takes effect and is required only if the subscription billing method is selected for master nodes.
        /// 
        /// Valid values: 1, 2, 3, 6, and 12.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("master_auto_renew_period")]
        [Validation(Required=false)]
        public long? MasterAutoRenewPeriod { get; set; }

        /// <summary>
        /// The number of master nodes. Valid values: `3` and `5`.
        /// 
        /// Default value: `3`.
        /// </summary>
        [NameInMap("master_count")]
        [Validation(Required=false)]
        public long? MasterCount { get; set; }

        /// <summary>
        /// The billing method of master nodes. Valid values:
        /// 
        /// *   `PrePaid`: subscription.
        /// *   `PostPaid`: pay-as-you-go.
        /// 
        /// Default value: `PostPaid`.
        /// </summary>
        [NameInMap("master_instance_charge_type")]
        [Validation(Required=false)]
        public string MasterInstanceChargeType { get; set; }

        /// <summary>
        /// The Elastic Compute Service (ECS) instance types of master nodes. For more information, see [Overview of instance families](~~25378~~).
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        public List<string> MasterInstanceTypes { get; set; }

        /// <summary>
        /// The subscription duration of master nodes. This parameter takes effect and is required only if `master_instance_charge_type` is set to `PrePaid`.
        /// 
        /// Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("master_period")]
        [Validation(Required=false)]
        public long? MasterPeriod { get; set; }

        /// <summary>
        /// The billing cycle of master nodes. This parameter is required if master_instance_charge_type is set to `PrePaid`.
        /// 
        /// Set the value to `Month`. Master nodes are billed only on a monthly basis.
        /// </summary>
        [NameInMap("master_period_unit")]
        [Validation(Required=false)]
        public string MasterPeriodUnit { get; set; }

        /// <summary>
        /// The type of system disk that you want to use for master nodes. Valid values:
        /// 
        /// *   `cloud_efficiency`: ultra disk.
        /// *   `cloud_ssd`: standard SSD.
        /// *   `cloud_essd`: ESSD.
        /// 
        /// Default value: `cloud_ssd`. The default value may vary in different zones.
        /// </summary>
        [NameInMap("master_system_disk_category")]
        [Validation(Required=false)]
        public string MasterSystemDiskCategory { get; set; }

        /// <summary>
        /// The performance level (PL) of the system disk that you want to use for master nodes. This parameter takes effect only for enhanced SSDs. For more information about the relationship between disk PLs and disk sizes, see [ESSDs](~~122389~~).
        /// </summary>
        [NameInMap("master_system_disk_performance_level")]
        [Validation(Required=false)]
        public string MasterSystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The size of the system disk that you want to use for master nodes. Valid values: 40 to 500. Unit: GiB.
        /// 
        /// Default value: `120`.
        /// </summary>
        [NameInMap("master_system_disk_size")]
        [Validation(Required=false)]
        public long? MasterSystemDiskSize { get; set; }

        /// <summary>
        /// The ID of the automatic snapshot policy that you want to use for the system disks of master nodes.
        /// </summary>
        [NameInMap("master_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        public string MasterSystemDiskSnapshotPolicyId { get; set; }

        /// <summary>
        /// The IDs of the vSwitches that are specified for master nodes. You can specify up to three vSwitches. We recommend that you specify three vSwitches in different zones to ensure high availability.
        /// 
        /// The number of vSwitches must be the same as that specified in `master_count` and the same as those specified in `master_vswitch_ids`.
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// The cluster name.
        /// 
        /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether to create a NAT gateway and configure Source Network Address Translation (SNAT) rules when the system creates the ACK Serverless cluster. Valid values:
        /// 
        /// *   `true`: automatically creates a NAT gateway and configures SNAT rules. This enables Internet access for the VPC in which the cluster is deployed.
        /// *   `false`: does not create a NAT gateway or configure SNAT rules. In this case, the cluster in the VPC cannot access the Internet.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("nat_gateway")]
        [Validation(Required=false)]
        public bool? NatGateway { get; set; }

        /// <summary>
        /// The maximum number of IP addresses that can be assigned to nodes. This number is determined by the node CIDR block. This parameter takes effect only if the cluster uses Flannel as the network plug-in.
        /// 
        /// Default value: `26`.
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <summary>
        /// The name of the custom node.
        /// 
        /// A custom node name consists of a prefix, an IP substring, and a suffix.
        /// 
        /// *   The prefix and suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-), and must start and end with a lowercase letter or digit.
        /// *   The IP substring length specifies the number of digits to be truncated from the end of the node IP address. The IP substring length ranges from 5 to 12.
        /// 
        /// For example, if the node IP address is 192.168.0.55, the prefix is aliyun.com, the length of the IP address substring is 5, and the suffix is test, the node name will be aliyun.com00055test.
        /// </summary>
        [NameInMap("node_name_mode")]
        [Validation(Required=false)]
        public string NodeNameMode { get; set; }

        /// <summary>
        /// The node port range. Valid values: 30000 to 65535.
        /// 
        /// Default value: `30000-32767`.
        /// </summary>
        [NameInMap("node_port_range")]
        [Validation(Required=false)]
        public string NodePortRange { get; set; }

        /// <summary>
        /// The list of node pools.
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<Nodepool> Nodepools { get; set; }

        /// <summary>
        /// The number of worker nodes. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? NumOfNodes { get; set; }

        /// <summary>
        /// The type of OS. Valid values:
        /// 
        /// *   Windows
        /// *   Linux
        /// 
        /// Default value: `Linux`.
        /// </summary>
        [NameInMap("os_type")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// The subscription duration.
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration.
        /// </summary>
        [NameInMap("period_unit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The release version of the operating system. Valid values:
        /// 
        /// *   CentOS
        /// *   AliyunLinux
        /// *   QbootAliyunLinux
        /// *   Qboot
        /// *   Windows
        /// *   WindowsCore
        /// 
        /// Default value: `CentOS`.
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The list of pod vSwitches. You need to specify at least one pod vSwitch for each node vSwitch and the pod vSwitches must not be the same as the node vSwitches (`vswitch`). We recommend that you specify pod vSwitches whose mask lengths are no greater than 19.
        /// 
        /// >  The `pod_vswitch_ids` parameter is required if the cluster uses Terway as the network plug-in.
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// The identifier that indicates whether the cluster is an ACK Edge cluster. To create an ACK Edge cluster, you must set this parameter to `Edge`.
        /// 
        /// *   `Default`: The cluster is not an ACK Edge cluster.
        /// *   `Edge`: The cluster is an ACK Edge cluster.
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// The kube-proxy mode. Valid values:
        /// 
        /// *   `iptables`: iptables is a mature and stable kube-proxy mode. It uses iptables rules to conduct service discovery and load balancing. The performance of this mode is restricted by the size of the Kubernetes cluster. This mode is suitable for Kubernetes clusters that manage a small number of Services.
        /// *   `ipvs`: IPVS is a high-performance kube-proxy mode. It uses Linux Virtual Server (LVS) to conduct service discovery and load balancing. This mode is suitable for clusters that manage a large number of Services. We recommend that you use this mode in scenarios where high-performance load balancing is required.
        /// 
        /// Default value: `ipvs`.
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// The list of ApsaraDB RDS instances. Select the ApsaraDB RDS instances that you want to add to the whitelist. We recommend that you add the CIDR block of pods and CIDR block of nodes to the ApsaraDB RDS instances in the ApsaraDB RDS console. When you set the ApsaraDB RDS instances, you cannot scale out the number of nodes because the instances are not in the Running state.
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// The ID of the region in which you want to deploy the cluster.
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the cluster belongs. You can use resource groups to isolate clusters.
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The container runtime. The default container runtime is Docker. containerd and Sandboxed-Container are also supported.
        /// 
        /// For more information about how to select a proper container runtime, see [Comparison of Docker, containerd, and Sandboxed-Container](https://help.aliyun.com/document_detail/160313.html).
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// The ID of an existing security group. You need to choose between this parameter and the `is_enterprise_security_group` parameter. Cluster nodes are automatically added to the security group.
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Service accounts provide identities for pods when pods communicate with the `API server` of the cluster. `service-account-issuer` is the issuer of the `serviceaccount token`, which corresponds to the `iss` field in the `token payload`.
        /// 
        /// For more information about `ServiceAccount`, see [Enable service account token volume projection](~~160384~~).
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// The CIDR block of Services. Valid values: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24. The CIDR block of Services cannot overlap with the CIDR block of the VPC (10.1.0.0/21) or the CIDR blocks of existing clusters in the VPC. You cannot modify the CIDR block of Services after the cluster is created.
        /// 
        /// By default, the CIDR block of Services is set to 172.19.0.0/20.
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// The type of service discovery that is implemented in the `ACK Serverless` cluster.
        /// 
        /// *   `CoreDNS`: a standard service discovery plug-in provided by open source Kubernetes. To use the Domain Name System (DNS) resolution, you must provision pods. By default, two elastic container instances are used. The specification of each instance is 0.25 CPU cores and 512 MiB of memory.
        /// *   `PrivateZone`: a DNS resolution service provided by Alibaba Cloud. You must activate Alibaba Cloud DNS PrivateZone before you can use it for service discovery.
        /// 
        /// By default, this parameter is not specified.
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// Specifies whether to configure SNAT rules for the VPC where your cluster is deployed. Valid values:
        /// 
        /// *   `true`: automatically creates a NAT gateway and configures SNAT rules. Set this parameter to `true` if nodes and applications in the cluster need to access the Internet.
        /// *   `false`: does not create a NAT gateway or configure SNAT rules. In this case, nodes and applications in the cluster cannot access the Internet.
        /// 
        /// >  If this feature is disabled when you create the cluster, you can also manually enable this feature after you create the cluster. For more information, see [Manually create a NAT gateway and configure SNAT rules](~~178480~~).
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("snat_entry")]
        [Validation(Required=false)]
        public bool? SnatEntry { get; set; }

        /// <summary>
        /// Reinforcement based on classified protection. For more information, see [ACK reinforcement based on classified protection](~~196148~~).
        /// 
        /// Valid values:
        /// 
        /// *   `true`: enables reinforcement based on classified protection.
        /// *   `false`: disables reinforcement based on classified protection.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("soc_enabled")]
        [Validation(Required=false)]
        public bool? SocEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable SSH logon over the Internet. If this parameter is set to true, you can log on to master nodes in an ACK dedicated cluster over the Internet. This parameter does not take effect in ACK managed clusters.
        /// 
        /// *   `true`: enables SSH logon over the Internet.
        /// *   `false`: disables SSH logon over the Internet.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        /// <summary>
        /// The labels that you want to add to nodes. You must add tags based on the following rules:
        /// 
        /// *   Each label is a case-sensitive key-value pair. You can add up to 20 labels.
        /// *   A key must be unique and cannot exceed 64 characters in length. A value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with aliyun, acs:, https://, or http://. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// The taints of the nodes in the node pool. Taints are added to nodes to prevent pods from being scheduled to inappropriate nodes. However, tolerations allow pods to be scheduled to nodes with matching taints. For more information, see [Taints and Tolerations](https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/).
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// Specifies the timeout period of cluster creation. Unit: minutes.
        /// 
        /// Default value: `60`.
        /// </summary>
        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        public long? TimeoutMins { get; set; }

        /// <summary>
        /// The time zone of the cluster.
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// The custom certificate authority (CA) certificate used by the cluster.
        /// </summary>
        [NameInMap("user_ca")]
        [Validation(Required=false)]
        public string UserCa { get; set; }

        /// <summary>
        /// The user data of nodes.
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) in which you want to deploy the cluster. This parameter is required.
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// The vSwitches that are specified for nodes in the cluster. This parameter is required when you create a managed Kubernetes cluster that does not contain nodes.
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for worker nodes. This parameter takes effect only if `worker_instance_charge_type` is set to `PrePaid`. Valid values:
        /// 
        /// *   `true`: enables auto-renewal.
        /// *   `false`: disables auto-renewal.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period for worker nodes after the subscriptions of worker nodes expire. This parameter takes effect and is required only if the subscription billing method is selected for worker nodes.
        /// 
        /// Valid values: 1, 2, 3, 6, and 12.
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// The configuration of the data disk that is mounted to worker nodes. The configuration includes disk type and disk size.
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        [Obsolete]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// The data disk type.
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// Specifies whether to encrypt a data disk. Valid values:
            /// 
            /// *   `true`: encrypts a data disk.
            /// *   `false`: does not encrypt a data disk.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// The performance level (PL) of a data disk. This parameter takes effect only on ESSDs. You can specify a higher PL if you increase the size of a data disk. For more information, see [ESSDs](~~122389~~).
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The size of the data disk. Valid values: 40 to 32767.
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// The billing method of worker nodes. Valid values:
        /// 
        /// *   `PrePaid`: subscription.
        /// *   `PostPaid`: pay-as-you-go.
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// The instance configurations of worker nodes.
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// The subscription duration of worker nodes. This parameter takes effect and is required only if `worker_instance_charge_type` is set to `PrePaid`.
        /// 
        /// Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? WorkerPeriod { get; set; }

        /// <summary>
        /// The billing cycle of worker nodes. This parameter is required if worker_instance_charge_type is set to `PrePaid`.
        /// 
        /// Set the value to `Month`. Worker nodes are billed only on a monthly basis.
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// The category of the system disk that you attach to the worker node. For more information, see [Elastic Block Storage devices](~~63136~~).
        /// 
        /// Valid values:
        /// 
        /// *   `cloud_efficiency`: ultra disk.
        /// *   `cloud_ssd`: standard SSD.
        /// 
        /// Default value: `cloud_ssd`.
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// If the system disk is an ESSD, you can set the PL of the ESSD. For more information, see [ESSDs](~~122389~~).
        /// 
        /// Valid values:
        /// 
        /// *   PL0
        /// *   PL1
        /// *   PL2
        /// *   PL3
        /// </summary>
        [NameInMap("worker_system_disk_performance_level")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerSystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The size of the system disk that you want to use for worker nodes. Unit: GiB.
        /// 
        /// Valid values: 40 to 500.
        /// 
        /// The value of this parameter must be at least 40 and no less than the image size.
        /// 
        /// Default value: `120`.
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        [Obsolete]
        public long? WorkerSystemDiskSize { get; set; }

        /// <summary>
        /// The ID of the automatic snapshot policy that you want to use for the system disks of worker nodes.
        /// </summary>
        [NameInMap("worker_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerSystemDiskSnapshotPolicyId { get; set; }

        /// <summary>
        /// The list of vSwitches that are specified for nodes. Each node is allocated a vSwitch.
        /// 
        /// The `worker_vswitch_ids` parameter is optional but the `vswitch_ids` parameter is required when you create an ACK managed cluster that does not contain nodes.
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <summary>
        /// The ID of the zone in which the cluster is deployed. This parameter takes effect in only ACK Serverless clusters.
        /// 
        /// When you create an ACK Serverless cluster, you must configure `zone_id` if `vpc_id` and `vswitch_ids` are not configured. This way, the system automatically creates a VPC in the specified zone.
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
