// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeClustersResponseBody> Body { get; set; }
        public class DescribeClustersResponseBody : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0123456789abcdef0123456789abcdef0</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01T08:00:00+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The current version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.32.1-aliyun.1</para>
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The data disk category of the node.</para>
            /// </summary>
            [NameInMap("data_disk_category")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The data disk size of the node.</para>
            /// </summary>
            [NameInMap("data_disk_size")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the cluster.</para>
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The Docker version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20.10.17</para>
            /// </summary>
            [NameInMap("docker_version")]
            [Validation(Required=false)]
            public string DockerVersion { get; set; }

            /// <summary>
            /// <para>The ID of the external load balancing instance used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-a1b2c3d4e5f6g7h8i9j0k</para>
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// <para>The initial version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.32.1-aliyun.1</para>
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// <para>The access address of the cluster API server, including the internal network access address and the public network access address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;api_server_endpoint&quot;:&quot;&quot;,&quot;intranet_api_server_endpoint&quot;:&quot;<a href="https://192.0.2.10:6443%22%7D">https://192.0.2.10:6443&quot;}</a></para>
            /// </summary>
            [NameInMap("master_url")]
            [Validation(Required=false)]
            public string MasterUrl { get; set; }

            /// <summary>
            /// <para>The metadata of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;addons&quot;:[{&quot;name&quot;:&quot;kube-proxy&quot;,&quot;version&quot;:&quot;v1.32.1&quot;}]}</para>
            /// </summary>
            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public string MetaData { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-cluster</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network mode of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("network_mode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// <para>Indicates whether Private Zone is enabled for the cluster. Default value: false.</para>
            /// </summary>
            [NameInMap("private_zone")]
            [Validation(Required=false)]
            public bool? PrivateZone { get; set; }

            /// <summary>
            /// <para>The subtype of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The region ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-a1b2c3d4e5f6g7h</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The current number of nodes in the cluster, including master and worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The state of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The subnet CIDR of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/16</para>
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// <para>The tags of the cluster.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeClustersResponseBodyTags> Tags { get; set; }
            public class DescribeClustersResponseBodyTags : TeaModel {
                /// <summary>
                /// <para>The key of the cluster tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.tag.key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the cluster tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-tag-value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the cluster was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-02T08:00:00+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <para>The VPC ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch CIDR.</para>
            /// </summary>
            [NameInMap("vswitch_cidr")]
            [Validation(Required=false)]
            public string VswitchCidr { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch where the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-a1b2c3d4e5f6g7h8i9j0k</para>
            /// </summary>
            [NameInMap("vswitch_id")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The name of the RAM role used by the worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-worker-ram-role</para>
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

            /// <summary>
            /// <para>The zone ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("zone_id")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
