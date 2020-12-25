// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeClustersResponseBody> Body { get; set; }
        public class DescribeClustersResponseBody : TeaModel {
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
            /// 节点系统盘类型。
            /// </summary>
            [NameInMap("data_disk_category")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// 节点系统盘大小。
            /// </summary>
            [NameInMap("data_disk_size")]
            [Validation(Required=false)]
            public long DataDiskSize { get; set; }

            /// <summary>
            /// 集群是否开启删除保护。
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// 容器运行时版本。
            /// </summary>
            [NameInMap("docker_version")]
            [Validation(Required=false)]
            public string DockerVersion { get; set; }

            /// <summary>
            /// 集群Ingerss SLB实例的ID。
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// 集群创建时版本。
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// 集群的endpoint地址。
            /// </summary>
            [NameInMap("master_url")]
            [Validation(Required=false)]
            public string MasterUrl { get; set; }

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
            /// 集群使用的网络类型。
            /// </summary>
            [NameInMap("network_mode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// 集群是否开启Private Zone，默认false。
            /// </summary>
            [NameInMap("private_zone")]
            [Validation(Required=false)]
            public bool? PrivateZone { get; set; }

            /// <summary>
            /// 集群标识，区分是否为边缘托管版。
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

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
            /// 集群内实例数量。
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
            /// POD网络。
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// 集群标签。
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeClustersResponseBodyTags> Tags { get; set; }
            public class DescribeClustersResponseBodyTags : TeaModel {
                /// <summary>
                /// 标签名。
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
            /// 集群使用的VPC ID。
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// 虚拟交换机网络ID。
            /// </summary>
            [NameInMap("vswitch_cidr")]
            [Validation(Required=false)]
            public string VswitchCidr { get; set; }

            /// <summary>
            /// 节点使用的Vswitch ID。
            /// </summary>
            [NameInMap("vswitch_id")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// 集群Worker节点RAM角色名称。
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

            /// <summary>
            /// 集群所在Region内的区域ID。
            /// </summary>
            [NameInMap("zone_id")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
