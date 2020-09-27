// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// 组件信息。
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAddons> Addons { get; set; }
        public class CreateClusterRequestAddons : TeaModel {
            /// <summary>
            /// 组件需要的配置。
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 是否安装云监控插件。
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// POD网络地址段。
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// CPU管理策略。
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// 集群是否开启删除保护。
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// 集群创建失败后是否回滚。
        /// </summary>
        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// 集群是否运行公网访问。
        /// </summary>
        [NameInMap("endpoint_public_access")]
        [Validation(Required=false)]
        public bool? EndpointPublicAccess { get; set; }

        /// <summary>
        /// 自定义镜像ID。
        /// </summary>
        [NameInMap("images_id")]
        [Validation(Required=false)]
        public string ImagesId { get; set; }

        /// <summary>
        /// 是否自动创建企业安全组，与security_group_id二选一。
        /// </summary>
        [NameInMap("is_enterprise_security_group")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// key_pair名称，和login_password二选一。
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// 集群版本好。
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// SSH登录密码，与key_pair二选一。
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// Master节点是否自动续费。
        /// </summary>
        [NameInMap("master_auto_renew")]
        [Validation(Required=false)]
        public bool? MasterAutoRenew { get; set; }

        /// <summary>
        /// Master节点自动续费周期。
        /// </summary>
        [NameInMap("master_auto_renew_period")]
        [Validation(Required=false)]
        public long? MasterAutoRenewPeriod { get; set; }

        /// <summary>
        /// Master节点数量。
        /// </summary>
        [NameInMap("master_count")]
        [Validation(Required=false)]
        public long? MasterCount { get; set; }

        /// <summary>
        /// Master节点付费类型。
        /// </summary>
        [NameInMap("master_instance_charge_type")]
        [Validation(Required=false)]
        public string MasterInstanceChargeType { get; set; }

        /// <summary>
        /// Master节点ECS规格类型。
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        public List<string> MasterInstanceTypes { get; set; }

        /// <summary>
        /// Master节点包年包月时长，当master_instance_charge_type取值为PrePaid时才生效且为必选值。
        /// </summary>
        [NameInMap("master_period")]
        [Validation(Required=false)]
        public long? MasterPeriod { get; set; }

        /// <summary>
        /// Master节点包年包月周期。
        /// </summary>
        [NameInMap("master_period_unit")]
        [Validation(Required=false)]
        public string MasterPeriodUnit { get; set; }

        /// <summary>
        /// Master节点系统盘类型。
        /// </summary>
        [NameInMap("master_system_disk_category")]
        [Validation(Required=false)]
        public string MasterSystemDiskCategory { get; set; }

        /// <summary>
        /// Master节点系统盘大小。
        /// </summary>
        [NameInMap("master_system_disk_size")]
        [Validation(Required=false)]
        public long? MasterSystemDiskSize { get; set; }

        /// <summary>
        /// Master节点交换机ID列表。
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// 集群名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 节点IP数量，这里通过CIDR来指定。
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <summary>
        /// 节点服务端口范围。
        /// </summary>
        [NameInMap("node_port_range")]
        [Validation(Required=false)]
        public string NodePortRange { get; set; }

        /// <summary>
        /// Worker节点数量。
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        public long? NumOfNodes { get; set; }

        /// <summary>
        /// 操作系统。
        /// </summary>
        [NameInMap("os_type")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// 操作系统发行版。
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Pod的虚拟交换机列表，在ENI多网卡模式下，需要传额外的VSwitch ID给addon。
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// 是否开启PrivateZone用于服务发现。
        /// </summary>
        [NameInMap("private_zone")]
        [Validation(Required=false)]
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// 边缘集群标识。
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// kube-proxy代理模式。
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// RDS列表，将该ECS加入到选择的RDS实例的白名单中。。
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// 集群所属地域ID。
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 容器运行时。
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public CreateClusterRequestRuntime Runtime { get; set; }
        public class CreateClusterRequestRuntime : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        /// <summary>
        /// 自定义安全组ID。
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Service网络地址段。
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// 集群是否配置SNAT。
        /// </summary>
        [NameInMap("snat_entry")]
        [Validation(Required=false)]
        public bool? SnatEntry { get; set; }

        /// <summary>
        /// 集群是否开启公网SSH登录。
        /// </summary>
        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        /// <summary>
        /// 集群标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTags> Tags { get; set; }
        public class CreateClusterRequestTags : TeaModel {
            /// <summary>
            /// 标签key。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 污点信息。
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTaints> Taints { get; set; }
        public class CreateClusterRequestTaints : TeaModel {
            /// <summary>
            /// 调度策略。
            /// </summary>
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// 污点key。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 污点值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 集群创建超时时间。
        /// </summary>
        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        public long? TimeoutMins { get; set; }

        /// <summary>
        /// 节点用户自定义数据。
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 集群使用的VPC。
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// 虚拟交换机列表。List长度范围为[1，3]。当集群类型为托管版或标准serverless集群时，该参数必填。
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Worker节点是否自动续费。
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// Worker节点自动续费周期。
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// Worker节点数据盘配置。
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// 数据盘是否开启云盘备份。
            /// </summary>
            [NameInMap("auto_snapshot_policy_id")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// 数据盘类型。
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// 数据盘是否加密。
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// 数据盘大小。
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// Worker节点付费类型。
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// Worker节点ECS实例类型。
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// Worker节点包年包月时长。
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long? WorkerPeriod { get; set; }

        /// <summary>
        /// Worker节点包年包月周期。
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// Worker节点系统盘类型。
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// Worker节点系统盘大小。
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

        /// <summary>
        /// 集群使用的虚拟交换机。
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> WorkerVswitchIds { get; set; }

        /// <summary>
        /// 集群所属地域内的可用区ID。
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
