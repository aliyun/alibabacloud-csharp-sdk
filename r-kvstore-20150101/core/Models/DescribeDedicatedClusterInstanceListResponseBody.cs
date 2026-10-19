// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDedicatedClusterInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance information.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeDedicatedClusterInstanceListResponseBodyInstances> Instances { get; set; }
        public class DescribeDedicatedClusterInstanceListResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The default bandwidth of the instance. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>The architecture type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>logic</b>: Cluster architecture.</description></item>
            /// <item><description><b>normal</b>: Standard architecture.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>logic</para>
            /// </summary>
            [NameInMap("CharacterType")]
            [Validation(Required=false)]
            public string CharacterType { get; set; }

            /// <summary>
            /// <para>The dedicated cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dhg-rx71fc5ndh9o****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The dedicated cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testname</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The direct connection endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-t4ncdi1dgi0ja8****.redis.hangzhou.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionDomain")]
            [Validation(Required=false)]
            public string ConnectionDomain { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-06T07:09:40Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The current bandwidth of the instance. Unit: MB/s. The value is the sum of the default bandwidth and the increased bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("CurrentBandWidth")]
            [Validation(Required=false)]
            public long? CurrentBandWidth { get; set; }

            /// <summary>
            /// <para>An internal parameter used for instance maintenance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4652****</para>
            /// </summary>
            [NameInMap("CustomId")]
            [Validation(Required=false)]
            public string CustomId { get; set; }

            /// <summary>
            /// <para>The database engine. The value is fixed as <b>redis</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version. The value is fixed as <b>5.0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis.cluster.sharding.common.ce</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1e7vl6ygf1yq****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The list of node information.</para>
            /// </summary>
            [NameInMap("InstanceNodeList")]
            [Validation(Required=false)]
            public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesInstanceNodeList> InstanceNodeList { get; set; }
            public class DescribeDedicatedClusterInstanceListResponseBodyInstancesInstanceNodeList : TeaModel {
                /// <summary>
                /// <para>The host ID in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ch-bp13vf0y9gx3c****</para>
                /// </summary>
                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1e7vl6ygf1yq****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17921111</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public int? NodeId { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.33.***</para>
                /// </summary>
                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>db</b>: Data node.</description></item>
                /// <item><description><b>proxy</b>: Proxy node.</description></item>
                /// <item><description><b>normal</b>: Regular node. This value is returned for instances that use the standard architecture.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The port of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3001</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The node role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master</b>: Primary node.</description></item>
                /// <item><description><b>slave</b>: Secondary node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The zone to which the node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// <item><description><b>Creating</b>: Creating.</description></item>
            /// <item><description><b>Changing</b>: Changing.</description></item>
            /// <item><description><b>Inactive</b>: Disabled.</description></item>
            /// <item><description><b>Flushing</b>: Purge in progress.</description></item>
            /// <item><description><b>Released</b>: Released.</description></item>
            /// <item><description><b>Transforming</b>: Transforming.</description></item>
            /// <item><description><b>Unavailable</b>: Unavailable.</description></item>
            /// <item><description><b>Error</b>: Creation failed.</description></item>
            /// <item><description><b>Migrating</b>: Migrating.</description></item>
            /// <item><description><b>BackupRecovering</b>: Restoring from backup.</description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: Minor version upgrade in progress.</description></item>
            /// <item><description><b>NetworkModifying</b>: Changing the network.</description></item>
            /// <item><description><b>SSLModifying</b>: Changing SSL configurations.</description></item>
            /// <item><description><b>MajorVersionUpgrading</b>: Major engine version upgrade in progress. The instance remains accessible.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window. The time is in the <i>HH:mm</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window. The time is in the <i>HH:mm</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The number of proxy nodes.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>A value of <b>0</b> indicates that the proxy mode is disabled for the instance. A value greater than <b>0</b> (such as <b>1</b>) indicates that the proxy mode is enabled for the instance.</description></item>
            /// <item><description>This parameter is returned only when the instance uses the <a href="https://help.aliyun.com/document_detail/52228.html">cluster architecture</a>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProxyCount")]
            [Validation(Required=false)]
            public int? ProxyCount { get; set; }

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
            /// <para>The number of data shards.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the instance uses the <a href="https://help.aliyun.com/document_detail/52228.html">cluster architecture</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ShardCount")]
            [Validation(Required=false)]
            public int? ShardCount { get; set; }

            /// <summary>
            /// <para>The storage type. The value is fixed as LOCAL_SSD (<a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disk (standard SSD)</a>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOCAL_SSD</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-t4n2clc70t3hqwsrr****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-t4nvrca24dczppq44****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-e</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>712CCF2A-16BD-411B-93F7-E978BEF2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
