// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        [NameInMap("charge_type")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("cis_enabled")]
        [Validation(Required=false)]
        public bool? CisEnabled { get; set; }

        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        [NameInMap("controlplane_log_ttl")]
        [Validation(Required=false)]
        public string ControlplaneLogTtl { get; set; }

        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        [NameInMap("custom_san")]
        [Validation(Required=false)]
        public string CustomSan { get; set; }

        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        [NameInMap("endpoint_public_access")]
        [Validation(Required=false)]
        public bool? EndpointPublicAccess { get; set; }

        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("image_type")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        [NameInMap("is_enterprise_security_group")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        [NameInMap("load_balancer_spec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        [NameInMap("logging_type")]
        [Validation(Required=false)]
        public string LoggingType { get; set; }

        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        [NameInMap("master_auto_renew")]
        [Validation(Required=false)]
        public bool? MasterAutoRenew { get; set; }

        [NameInMap("master_auto_renew_period")]
        [Validation(Required=false)]
        public long? MasterAutoRenewPeriod { get; set; }

        [NameInMap("master_count")]
        [Validation(Required=false)]
        public long? MasterCount { get; set; }

        [NameInMap("master_instance_charge_type")]
        [Validation(Required=false)]
        public string MasterInstanceChargeType { get; set; }

        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        public List<string> MasterInstanceTypes { get; set; }

        [NameInMap("master_period")]
        [Validation(Required=false)]
        public long? MasterPeriod { get; set; }

        [NameInMap("master_period_unit")]
        [Validation(Required=false)]
        public string MasterPeriodUnit { get; set; }

        [NameInMap("master_system_disk_category")]
        [Validation(Required=false)]
        public string MasterSystemDiskCategory { get; set; }

        [NameInMap("master_system_disk_performance_level")]
        [Validation(Required=false)]
        public string MasterSystemDiskPerformanceLevel { get; set; }

        [NameInMap("master_system_disk_size")]
        [Validation(Required=false)]
        public long? MasterSystemDiskSize { get; set; }

        [NameInMap("master_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        public string MasterSystemDiskSnapshotPolicyId { get; set; }

        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> MasterVswitchIds { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nat_gateway")]
        [Validation(Required=false)]
        public bool? NatGateway { get; set; }

        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        [NameInMap("node_name_mode")]
        [Validation(Required=false)]
        public string NodeNameMode { get; set; }

        [NameInMap("node_port_range")]
        [Validation(Required=false)]
        public string NodePortRange { get; set; }

        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        public long? NumOfNodes { get; set; }

        [NameInMap("os_type")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        [NameInMap("period_unit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        public List<string> ServiceDiscoveryTypes { get; set; }

        [NameInMap("snat_entry")]
        [Validation(Required=false)]
        public bool? SnatEntry { get; set; }

        [NameInMap("soc_enabled")]
        [Validation(Required=false)]
        public bool? SocEnabled { get; set; }

        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        public long? TimeoutMins { get; set; }

        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        [NameInMap("user_ca")]
        [Validation(Required=false)]
        public string UserCa { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long? WorkerPeriod { get; set; }

        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        [NameInMap("worker_system_disk_performance_level")]
        [Validation(Required=false)]
        public string WorkerSystemDiskPerformanceLevel { get; set; }

        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

        [NameInMap("worker_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        public string WorkerSystemDiskSnapshotPolicyId { get; set; }

        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> WorkerVswitchIds { get; set; }

        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
