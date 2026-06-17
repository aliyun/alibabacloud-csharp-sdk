// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>vnode</b>: The node is managed by ACK.</para>
        /// </description></item>
        /// <item><description><para><b>container</b>: A container that you can log on to.</para>
        /// </description></item>
        /// <item><description><para><b>maas</b>: Model-as-a-Service (MaaS).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vnode</para>
        /// </summary>
        [NameInMap("AiNodeType")]
        [Validation(Required=false)]
        public string AiNodeType { get; set; }

        /// <summary>
        /// <para>The API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x********</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the cluster. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: The cluster is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The cluster is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>DBNodeCreating</b>: Nodes are being added.</para>
        /// </description></item>
        /// <item><description><para><b>DBNodeDeleting</b>: Nodes are being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>ClassChanging</b>: The node specifications are being changed.</para>
        /// </description></item>
        /// <item><description><para><b>Deleted</b>: The cluster is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The details of the nodes.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>A list of data disks.</para>
            /// </summary>
            [NameInMap("ChildVolumes")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterAttributeResponseBodyDBNodesChildVolumes> ChildVolumes { get; set; }
            public class DescribeAIDBClusterAttributeResponseBodyDBNodesChildVolumes : TeaModel {
                /// <summary>
                /// <para>The mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp/CrowdStrike</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The disk name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jueming</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The size of the data disk in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("SizeGB")]
                [Validation(Required=false)]
                public string SizeGB { get; set; }

                /// <summary>
                /// <para>The storage category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PolarFs</para>
                /// </summary>
                [NameInMap("StorageCategory")]
                [Validation(Required=false)]
                public string StorageCategory { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-14T05:58:42Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The node specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.pg.g8.8xlarge.gu30</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The node description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBNodeDescription")]
            [Validation(Required=false)]
            public string DBNodeDescription { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The node is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: The node is running.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The node is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>Rebooting</b>: The node is being rebooted.</para>
            /// </description></item>
            /// <item><description><para><b>DBNodeCreating</b>: A node is being added to the cluster.</para>
            /// </description></item>
            /// <item><description><para><b>DBNodeDeleting</b>: A node is being deleted from the cluster.</para>
            /// </description></item>
            /// <item><description><para><b>ClassChanging</b>: The node specifications are being changed.</para>
            /// </description></item>
            /// <item><description><para><b>MinorVersionUpgrading</b>: The minor version is being updated.</para>
            /// </description></item>
            /// <item><description><para><b>Maintaining</b>: The node is being maintained.</para>
            /// </description></item>
            /// <item><description><para><b>Switching</b>: A failover is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.*.*12</para>
            /// </summary>
            [NameInMap("LinkIP")]
            [Validation(Required=false)]
            public string LinkIP { get; set; }

            /// <summary>
            /// <para>The memory size in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.101.101.101</para>
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <para>The Kubernetes virtual node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vn-***************</para>
            /// </summary>
            [NameInMap("VNodeId")]
            [Validation(Required=false)]
            public string VNodeId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-*******************</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-*********************</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-d</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The cluster version. Valid values:</para>
        /// <para><b>1.0</b></para>
        /// <para><b>2.0</b></para>
        /// <para><b>3.0</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-xxxxxx</para>
        /// </summary>
        [NameInMap("EcsSecurityGroupId")]
        [Validation(Required=false)]
        public string EcsSecurityGroupId { get; set; }

        /// <summary>
        /// <para>A list of endpoints for the instance.</para>
        /// </summary>
        [NameInMap("EndpointList")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyEndpointList> EndpointList { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyEndpointList : TeaModel {
            /// <summary>
            /// <para>A list of network information for the instance.</para>
            /// </summary>
            [NameInMap("NetInfoItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterAttributeResponseBodyEndpointListNetInfoItems> NetInfoItems { get; set; }
            public class DescribeAIDBClusterAttributeResponseBodyEndpointListNetInfoItems : TeaModel {
                /// <summary>
                /// <para>The database endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-**********.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Public</b>: A public endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>Private</b>: A private endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>Inner</b>: A private endpoint in a classic network.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Public</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// <para>The expiration time of the cluster.</para>
        /// <remarks>
        /// <para>This parameter is returned only for <b>subscription</b> clusters. For <b>pay-as-you-go</b> clusters, an empty string is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>The private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.<em>.</em>.72</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The KVCache instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkv-xxxxx</para>
        /// </summary>
        [NameInMap("KVCacheInstanceId")]
        [Validation(Required=false)]
        public string KVCacheInstanceId { get; set; }

        /// <summary>
        /// <para>The ACK cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("KubeClusterId")]
        [Validation(Required=false)]
        public string KubeClusterId { get; set; }

        /// <summary>
        /// <para>The lock mode of the instance. A value of <b>lock</b> indicates that the instance is locked due to expiration or an overdue payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maximum number of queries per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxQPM")]
        [Validation(Required=false)]
        public string MaxQPM { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-Embedding-8B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBEAA83D-1734-42E3-85E3-E25F6E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The architecture type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>container</b>: AI container.</para>
        /// </description></item>
        /// <item><description><para><b>ainode</b>: AI node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>container</para>
        /// </summary>
        [NameInMap("RunType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// <para>The storage type for Enterprise Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PSL5</b></para>
        /// </description></item>
        /// <item><description><para><b>PSL4</b></para>
        /// </description></item>
        /// </list>
        /// <para>The storage type for Standard Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ESSDPL0</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL1</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL2</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL3</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDAUTOPL</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>essdpl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>A list of data disks.</para>
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyVolumes> Volumes { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyVolumes : TeaModel {
            /// <summary>
            /// <para>The mount path in the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/var/run/secrets/kubernetes.io/serviceaccount</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The disk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The storage size in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("SizeGB")]
            [Validation(Required=false)]
            public string SizeGB { get; set; }

            /// <summary>
            /// <para>The storage category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("StorageCategory")]
            [Validation(Required=false)]
            public string StorageCategory { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolarFs</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the zone in which the PolarDB cluster nodes are deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i,cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}
