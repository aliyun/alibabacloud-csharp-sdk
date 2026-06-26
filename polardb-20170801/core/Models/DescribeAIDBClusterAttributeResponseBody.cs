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
        /// <item><description>vnode: managed by ACK</description></item>
        /// <item><description>container: logon-enabled container</description></item>
        /// <item><description>maas: model service.</description></item>
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
        /// <para>The cluster creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The cluster description. Fuzzy match is supported.</para>
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
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: being created</description></item>
        /// <item><description><b>Running</b>: running</description></item>
        /// <item><description><b>Deleting</b>: being released</description></item>
        /// <item><description><b>DBNodeCreating</b>: adding a node</description></item>
        /// <item><description><b>DBNodeDeleting</b>: deleting a node</description></item>
        /// <item><description><b>ClassChanging</b>: changing node specifications </description></item>
        /// <item><description><b>Deleted</b>: released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The node details.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>The list of data cloud disks.</para>
            /// </summary>
            [NameInMap("ChildVolumes")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterAttributeResponseBodyDBNodesChildVolumes> ChildVolumes { get; set; }
            public class DescribeAIDBClusterAttributeResponseBodyDBNodesChildVolumes : TeaModel {
                /// <summary>
                /// <para>The actual mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp/CrowdStrike</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The cloud disk name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jueming</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The storage size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("SizeGB")]
                [Validation(Required=false)]
                public string SizeGB { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PolarFs</para>
                /// </summary>
                [NameInMap("StorageCategory")]
                [Validation(Required=false)]
                public string StorageCategory { get; set; }

                /// <summary>
                /// <para>The storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            /// <summary>
            /// <para>The number of CPU cores of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-14T05:58:42Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The cluster specifications.</para>
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
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: being created </description></item>
            /// <item><description><b>Running</b>: running </description></item>
            /// <item><description><b>Deleting</b>: being deleted  </description></item>
            /// <item><description><b>Rebooting</b>: restarting  </description></item>
            /// <item><description><b>DBNodeCreating</b>: adding a node  </description></item>
            /// <item><description><b>DBNodeDeleting</b>: deleting a node </description></item>
            /// <item><description><b>ClassChanging</b>: changing node specifications  </description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: upgrading the minor engine version</description></item>
            /// <item><description><b>Maintaining</b>: under maintenance  </description></item>
            /// <item><description><b>Switching</b>: switching.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The number of GPU cards.</para>
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
            /// <para>The memory size of the node. Unit: MB.</para>
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
        /// <para><b>3.0</b>.</para>
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
        /// <para>The list of network connection addresses of the instance.</para>
        /// </summary>
        [NameInMap("EndpointList")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyEndpointList> EndpointList { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyEndpointList : TeaModel {
            /// <summary>
            /// <para>The list of network information of the instance.</para>
            /// </summary>
            [NameInMap("NetInfoItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterAttributeResponseBodyEndpointListNetInfoItems> NetInfoItems { get; set; }
            public class DescribeAIDBClusterAttributeResponseBodyEndpointListNetInfoItems : TeaModel {
                /// <summary>
                /// <para>The database connection address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-**********.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The network type of the connection string. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: public endpoint</description></item>
                /// <item><description><b>Private</b>: private endpoint</description></item>
                /// <item><description><b>Inner</b>: private endpoint (classic network).</description></item>
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
        /// <para>The cluster expiration time.</para>
        /// <remarks>
        /// <para>This parameter is returned only for <b>Prepaid</b> (subscription) clusters. An empty value is returned for <b>Postpaid</b> (pay-as-you-go) clusters.</para>
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
        /// <item><description><para><b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The internal IP address.</para>
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
        /// <para>The instance lock mode. The value <b>lock</b> indicates that the instance is automatically locked due to expiration or overdue payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maximum number of requests per minute.</para>
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
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
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
        /// <para>Id of the request</para>
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
        /// <item><description>container: AI container</description></item>
        /// <item><description>ainode: AI node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>container</para>
        /// </summary>
        [NameInMap("RunType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// <para>Valid values for PolarDB Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>PSL5</b></description></item>
        /// <item><description><b>PSL4</b></description></item>
        /// </list>
        /// <para>Valid values for PolarDB for MySQL Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL2</b></description></item>
        /// <item><description><b>ESSDPL3</b></description></item>
        /// <item><description><b>ESSDAUTOPL</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>essdpl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The VPC ID specified for the zone switchover.</para>
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
        /// <para>If VPCId is specified, VSwitchId is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The list of data cloud disks.</para>
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
            /// <para>The cloud disk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The storage size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("SizeGB")]
            [Validation(Required=false)]
            public string SizeGB { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("StorageCategory")]
            [Validation(Required=false)]
            public string StorageCategory { get; set; }

            /// <summary>
            /// <para>The storage class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolarFs</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the PolarDB cluster node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i,cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}
