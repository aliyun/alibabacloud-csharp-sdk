// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// 集群名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 托管版集群类型
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// 集群版本
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// 集群专有网络ID。
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// 创建Terway网络类型的集群时，需要为pod指定单独的虚拟交换机
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// POD网络网段
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// 服务网络网段
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// 安全组ID，和is_enterprise_security_group二选一
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 自动创建企业安全组
        /// </summary>
        [NameInMap("is_enterprise_security_group")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// 若您集群内的节点、应用等需要访问公网，勾选该项后我们将为您创建 NAT 网关并自动配置 SNAT 规则
        /// </summary>
        [NameInMap("snat_entry")]
        [Validation(Required=false)]
        public bool? SnatEntry { get; set; }

        /// <summary>
        /// 使用EIP暴露apiServer
        /// </summary>
        [NameInMap("endpoint_public_access")]
        [Validation(Required=false)]
        public bool? EndpointPublicAccess { get; set; }

        /// <summary>
        /// 允许公网ssh登录
        /// </summary>
        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// 节点IP数量
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <summary>
        /// 自定义集群CA
        /// </summary>
        [NameInMap("user_ca")]
        [Validation(Required=false)]
        public string UserCa { get; set; }

        /// <summary>
        /// 节点自定义数据
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 集群本地域名
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// 自定义节点名称
        /// </summary>
        [NameInMap("node_name_mode")]
        [Validation(Required=false)]
        public string NodeNameMode { get; set; }

        /// <summary>
        /// 自定义证书SAN
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        public string CustomSan { get; set; }

        /// <summary>
        /// Secret落盘加密
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// serviceaccount token中的签发身份，即token payload中的iss字段。
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// 合法的请求token身份，用于apiserver服务端认证请求token是否合法。
        /// </summary>
        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        /// <summary>
        /// 自定义镜像
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// RDS白名单
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// 集群标签
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 集群组件配置
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// 节点污点信息
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 为ECS安装云监控
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// 操作系统发行版
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// 操作系统平台类型
        /// </summary>
        [NameInMap("os_type")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// CPU策略
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// Proxy代理模式，ipvs|iptables
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// 节点服务端口范围
        /// </summary>
        [NameInMap("node_port_range")]
        [Validation(Required=false)]
        public string NodePortRange { get; set; }

        /// <summary>
        /// 密钥对名称，和login_password二选一。
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// SSH登录密码。密码规则为8~30 个字符，且至少同时包含三项（大小写字母、数字和特殊符号），和key_pair二选一。
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// 集群Master节点数量
        /// </summary>
        [NameInMap("master_count")]
        [Validation(Required=false)]
        public long MasterCount { get; set; }

        /// <summary>
        /// 集群Master节点使用的虚拟交换机
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// 集群Master节点类型
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        public List<string> MasterInstanceTypes { get; set; }

        /// <summary>
        /// 集群Master节点系统盘类型
        /// </summary>
        [NameInMap("master_system_disk_category")]
        [Validation(Required=false)]
        public string MasterSystemDiskCategory { get; set; }

        /// <summary>
        /// 集群Master节点系统盘大小，至少40
        /// </summary>
        [NameInMap("master_system_disk_size")]
        [Validation(Required=false)]
        public long MasterSystemDiskSize { get; set; }

        /// <summary>
        /// 集群Master节点自动快照备份策略
        /// </summary>
        [NameInMap("master_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        public string MasterSystemDiskSnapshotPolicyId { get; set; }

        /// <summary>
        /// 集群Master节点付费类型
        /// </summary>
        [NameInMap("master_instance_charge_type")]
        [Validation(Required=false)]
        public string MasterInstanceChargeType { get; set; }

        /// <summary>
        /// 集群Master节点包年包月周期
        /// </summary>
        [NameInMap("master_period_unit")]
        [Validation(Required=false)]
        public string MasterPeriodUnit { get; set; }

        /// <summary>
        /// 集群Master节点包年包月时长
        /// </summary>
        [NameInMap("master_period")]
        [Validation(Required=false)]
        public long MasterPeriod { get; set; }

        /// <summary>
        /// 集群Master节点是否自动续费
        /// </summary>
        [NameInMap("master_auto_renew")]
        [Validation(Required=false)]
        public bool? MasterAutoRenew { get; set; }

        /// <summary>
        /// 集群Master节点自动续费时长
        /// </summary>
        [NameInMap("master_auto_renew_period")]
        [Validation(Required=false)]
        public long MasterAutoRenewPeriod { get; set; }

        /// <summary>
        /// 集群Worker节点数量
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        public long NumOfNodes { get; set; }

        /// <summary>
        /// 集群Worker节点所在虚拟交换机
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> WorkerVswitchIds { get; set; }

        /// <summary>
        /// 集群Worker节点类型
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// 集群Worker节点系统盘类型
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// 集群Worker节点系统盘大小
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long WorkerSystemDiskSize { get; set; }

        /// <summary>
        /// 集群Worker节点系统盘快照备份策略
        /// </summary>
        [NameInMap("worker_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        public string WorkerSystemDiskSnapshotPolicyId { get; set; }

        /// <summary>
        /// 集群Worker节点数据盘配置
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<DataDisk> WorkerDataDisks { get; set; }

        /// <summary>
        /// 集群Worker节点付费类型
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// 集群Worker节点包年包月周期
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// 集群Worker节点包年包月时长
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long WorkerPeriod { get; set; }

        /// <summary>
        /// 集群Worker节点到期是否自动续费
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// 集群Worker节点自动续费时长
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// 使用已有节点创建集群时，已有实例列表
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// 使用已有节点创建集群时，是否格式化已有实例的磁盘
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// 使用已有节点创建集群时，是否保留实例名称。
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// 创建ASK集群时，服务发现类型
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// 使用自动创建专有网络创建ASK集群时，是否在vpc中创建Nat网关并配置SNAT规则。
        /// </summary>
        [NameInMap("nat_gateway")]
        [Validation(Required=false)]
        public bool? NatGateway { get; set; }

        /// <summary>
        /// 使用自动创建专有网络创建ASK集群时，需要指定专有网络的可用区
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// 面向场景时的集群类型。  Default：非边缘场景集群。 Edge：边缘场景集群。
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// 集群删除保护
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// 失败回滚
        /// </summary>
        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// 集群创建超时时间
        /// </summary>
        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        public long TimeoutMins { get; set; }

    }

}
