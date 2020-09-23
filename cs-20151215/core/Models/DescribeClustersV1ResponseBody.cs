// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// 集群详情列表。
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// 集群健康状态。
            /// </summary>
            [NameInMap("cluster_healthy")]
            [Validation(Required=false)]
            public string ClusterHealthy { get; set; }

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
            /// 集群当前版本。
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// 数据盘类型。
            /// </summary>
            [NameInMap("data_disk_category")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// 数据盘大小。
            /// </summary>
            [NameInMap("data_disk_size")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }

            /// <summary>
            /// 集群是否开启删除保护。
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// 集群使用的Docker版本。
            /// </summary>
            [NameInMap("docker_version")]
            [Validation(Required=false)]
            public string DockerVersion { get; set; }

            /// <summary>
            /// 集群Ingress对应的SLB的地址。
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// 集群初始化版本。
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// 集群访问的端点信息。
            /// </summary>
            [NameInMap("master_url")]
            [Validation(Required=false)]
            public string MasterUrl { get; set; }

            /// <summary>
            /// 集群元数据信息。
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
            /// 集群使用的网络类型，例如：VPC网络。
            /// </summary>
            [NameInMap("network_mode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// 节点状态。
            /// </summary>
            [NameInMap("node_status")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// 集群是否开启Private Zone。
            /// </summary>
            [NameInMap("private_zone")]
            [Validation(Required=false)]
            public bool? PrivateZone { get; set; }

            /// <summary>
            /// 边缘集群表示，用于区分边缘托管版集群。
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// 地域ID。
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
            /// 集群节点数。
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// 集群运行状态。
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// POD网段地址。
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// 集群标签。
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeClustersV1ResponseBodyClustersTags> Tags { get; set; }
            public class DescribeClustersV1ResponseBodyClustersTags : TeaModel {
                /// <summary>
                /// 标签键。
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
            /// 集群更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// 集群所在的VPC ID。
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// 虚拟交换机CIDR。
            /// </summary>
            [NameInMap("vswitch_cidr")]
            [Validation(Required=false)]
            public string VswitchCidr { get; set; }

            /// <summary>
            /// 集群使用的虚拟交换ID。
            /// </summary>
            [NameInMap("vswitch_id")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// 集群Worker RAM角色。
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

            /// <summary>
            /// 可用区ID。
            /// </summary>
            [NameInMap("zone_id")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// 分页信息。
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClustersV1ResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClustersV1ResponseBodyPageInfo : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
