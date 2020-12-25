// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群类型。
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 集群创建时间。
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// 集群初始化版本。
        /// </summary>
        [NameInMap("init_version")]
        [Validation(Required=false)]
        public string InitVersion { get; set; }

        /// <summary>
        /// 集群当前版本。
        /// </summary>
        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 集群可升级版本。
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// 集群是否开启删除保护。
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// 集群内Docker版本。
        /// </summary>
        [NameInMap("docker_version")]
        [Validation(Required=false)]
        public string DockerVersion { get; set; }

        /// <summary>
        /// 集群Ingress LB实例ID。
        /// </summary>
        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        public string ExternalLoadbalancerId { get; set; }

        /// <summary>
        /// 集群元数据。
        /// </summary>
        [NameInMap("meta_data")]
        [Validation(Required=false)]
        public string MetaData { get; set; }

        /// <summary>
        /// 集群名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 集群采用的网络类型，例如：VPC网络。
        /// </summary>
        [NameInMap("network_mode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// 集群所在地域ID。
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 集群资源组ID。
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// 集群安全组ID。
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 集群节点数量。
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long Size { get; set; }

        /// <summary>
        /// 集群运行状态。
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// 集群标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 集群更新时间。
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

        /// <summary>
        /// 集群使用的VPC ID。
        /// </summary>
        [NameInMap("vpc_id")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// 集群节点使用的虚拟交换机列表。
        /// </summary>
        [NameInMap("vswitch_id")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// Pod网络地址段，必须是有效的私有网段，即以下网段及其子网：10.0.0.0/8，172.16-31.0.0/12-16，192.168.0.0/16。不能与 VPC 及VPC 内已有 Kubernetes 集群使用的网段重复，创建成功后不能修改。  有关集群网络规划，请参见：[VPC下 Kubernetes 的网络地址段规划](https://help.aliyun.com/document_detail/～～86500～～)。
        /// </summary>
        [NameInMap("subnet_cidr")]
        [Validation(Required=false)]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// 集群所在地域内的可用区ID。
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// 集群访问地址。
        /// </summary>
        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        /// <summary>
        /// 集群是否启用用PrivateZone。  true：启用 false：不启用 默认值：false。
        /// </summary>
        [NameInMap("private_zone")]
        [Validation(Required=false)]
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// 面向场景时的集群类型。  Default：非边缘场景集群。 Edge：边缘场景集群。
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// 托管版集群类型，面向托管集群。  ack.pro.small：专业托管集群。 ack.standard ：标准托管集群。
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// Worker节点RAM角色名称。
        /// </summary>
        [NameInMap("worker_ram_role_name")]
        [Validation(Required=false)]
        public string WorkerRamRoleName { get; set; }

        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// 创建集群参数。
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// 集群创建的资源列表。
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public List<DescribeClusterDetailResponseBodyOutputs> Outputs { get; set; }
        public class DescribeClusterDetailResponseBodyOutputs : TeaModel {
            /// <summary>
            /// 资源ID。
            /// </summary>
            [NameInMap("OutputKey")]
            [Validation(Required=false)]
            public string OutputKey { get; set; }

            /// <summary>
            /// 资源名称。
            /// </summary>
            [NameInMap("OutputValue")]
            [Validation(Required=false)]
            public string OutputValue { get; set; }

            /// <summary>
            /// 资源描述。
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

    }

}
