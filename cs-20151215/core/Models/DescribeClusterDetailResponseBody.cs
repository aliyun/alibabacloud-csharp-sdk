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
        /// 集群当前K8S版本。
        /// </summary>
        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

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
        /// 集群Ingress SLB ID。
        /// </summary>
        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        public string ExternalLoadbalancerId { get; set; }

        /// <summary>
        /// 集群实例类型。
        /// </summary>
        [NameInMap("instance_type")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

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
        public int? Size { get; set; }

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
        public List<DescribeClusterDetailResponseBodyTags> Tags { get; set; }
        public class DescribeClusterDetailResponseBodyTags : TeaModel {
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
        /// 集群使用的虚拟交换机ID。
        /// </summary>
        [NameInMap("vswitch_cidr")]
        [Validation(Required=false)]
        public string VswitchCidr { get; set; }

        /// <summary>
        /// 集群节点使用的虚拟交换机列表。
        /// </summary>
        [NameInMap("vswitch_id")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// 集群所在地域内的可用区ID。
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
