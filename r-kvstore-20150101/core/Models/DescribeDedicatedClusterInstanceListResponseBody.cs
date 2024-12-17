// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDedicatedClusterInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeDedicatedClusterInstanceListResponseBodyInstances> Instances { get; set; }
        public class DescribeDedicatedClusterInstanceListResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The default bandwidth of the instance. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>The architecture of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>logic</b>: cluster</description></item>
            /// <item><description><b>normal</b>: standard</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>logic</para>
            /// </summary>
            [NameInMap("CharacterType")]
            [Validation(Required=false)]
            public string CharacterType { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated cluster to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dhg-rx71fc5ndh9o****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the dedicated cluster to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testname</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The private endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-t4ncdi1dgi0ja8****.redis.hangzhou.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionDomain")]
            [Validation(Required=false)]
            public string ConnectionDomain { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-06T07:09:40Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The current bandwidth of the instance, which is the sum of the default bandwidth and any extra bandwidth that is purchased. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("CurrentBandWidth")]
            [Validation(Required=false)]
            public long? CurrentBandWidth { get; set; }

            /// <summary>
            /// <para>An internal parameter used for the maintenance and management of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4652****</para>
            /// </summary>
            [NameInMap("CustomId")]
            [Validation(Required=false)]
            public string CustomId { get; set; }

            /// <summary>
            /// <para>The database engine. The return value is <b>redis</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version of the instance. The return value is <b>5.0</b>.</para>
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
            /// <para>The ID of the instance.</para>
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
            /// <para>The nodes.</para>
            /// </summary>
            [NameInMap("InstanceNodeList")]
            [Validation(Required=false)]
            public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesInstanceNodeList> InstanceNodeList { get; set; }
            public class DescribeDedicatedClusterInstanceListResponseBodyInstancesInstanceNodeList : TeaModel {
                /// <summary>
                /// <para>The ID of the host in the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ch-bp13vf0y9gx3c****</para>
                /// </summary>
                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
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
                /// <item><description><b>db</b>: data node.</description></item>
                /// <item><description><b>proxy</b>: proxy node.</description></item>
                /// <item><description><b>normal</b>: regular node. This value is returned when the instance runs in the standard architecture.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3001</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The role of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master</b>: master node</description></item>
                /// <item><description><b>slave</b>: replica node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The zone ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The state of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The instance is normal.</description></item>
            /// <item><description><b>Creating</b>: The instance is being created.</description></item>
            /// <item><description><b>Changing</b>: The configurations of the instance are being changed.</description></item>
            /// <item><description><b>Inactive</b>: The instance is disabled.</description></item>
            /// <item><description><b>Flushing</b>: The instance is being released.</description></item>
            /// <item><description><b>Released</b>: The instance is released.</description></item>
            /// <item><description><b>Transforming</b>: The billing method of the instance is being changed.</description></item>
            /// <item><description><b>Unavailable</b>: The instance is unavailable.</description></item>
            /// <item><description><b>Error</b>: The instance failed to be created.</description></item>
            /// <item><description><b>Migrating</b>: The instance is being migrated.</description></item>
            /// <item><description><b>BackupRecovering</b>: The instance is being restored from a backup.</description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the instance is being updated.</description></item>
            /// <item><description><b>NetworkModifying</b>: The network type of the instance is being changed.</description></item>
            /// <item><description><b>SSLModifying</b>: The SSL configurations of the instance are being changed.</description></item>
            /// <item><description><b>MajorVersionUpgrading</b>: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window. The time is in the <em>HH:mm</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window. The time is in the <em>HH:mm</em>Z format. The time is displayed in UTC.</para>
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
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If the return value is <b>0</b>, the proxy mode is disabled for the instance. If the return value is an integer greater than <b>0</b>, such as <b>1</b>, the proxy mode is enabled for the instance.</para>
            /// </description></item>
            /// <item><description><para>This parameter is returned only when the instance is a cluster instance. For more information about cluster instances, see <a href="https://help.aliyun.com/document_detail/52228.html">Cluster master-replica instances</a>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProxyCount")]
            [Validation(Required=false)]
            public int? ProxyCount { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the instance is a cluster instance. For more information about cluster instances, see <a href="https://help.aliyun.com/document_detail/52228.html">Cluster master-replica instances</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ShardCount")]
            [Validation(Required=false)]
            public int? ShardCount { get; set; }

            /// <summary>
            /// <para>The storage type of the instance. The return value is LOCAL_SSD, which indicates <a href="https://help.aliyun.com/document_detail/122389.html">enhanced SSDs (ESSDs)</a>.</para>
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
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>712CCF2A-16BD-411B-93F7-E978BEF2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
