// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDedicatedClusterInstanceListResponseBody : TeaModel {
        /// <summary>
        /// Details of the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeDedicatedClusterInstanceListResponseBodyInstances> Instances { get; set; }
        public class DescribeDedicatedClusterInstanceListResponseBodyInstances : TeaModel {
            /// <summary>
            /// The default bandwidth of the instance. Unit: Mbit/s.
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// The architecture of the instance. Valid values:
            /// 
            /// *   **logic**: cluster
            /// *   **normal**: standard
            /// </summary>
            [NameInMap("CharacterType")]
            [Validation(Required=false)]
            public string CharacterType { get; set; }

            /// <summary>
            /// The ID of the dedicated cluster to which the instance belongs.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the dedicated cluster to which the instance belongs.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The private endpoint of the instance.
            /// </summary>
            [NameInMap("ConnectionDomain")]
            [Validation(Required=false)]
            public string ConnectionDomain { get; set; }

            /// <summary>
            /// The time when the instance was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The current bandwidth of the instance, which is the sum of the default bandwidth and any extra bandwidth that is purchased. Unit: Mbit/s.
            /// </summary>
            [NameInMap("CurrentBandWidth")]
            [Validation(Required=false)]
            public long? CurrentBandWidth { get; set; }

            /// <summary>
            /// An internal parameter used for the maintenance and management of instances.
            /// </summary>
            [NameInMap("CustomId")]
            [Validation(Required=false)]
            public string CustomId { get; set; }

            /// <summary>
            /// The database engine. The return value is **redis**.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The database engine version of the instance. The return value is **5.0**.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The instance type.
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The nodes.
            /// </summary>
            [NameInMap("InstanceNodeList")]
            [Validation(Required=false)]
            public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesInstanceNodeList> InstanceNodeList { get; set; }
            public class DescribeDedicatedClusterInstanceListResponseBodyInstancesInstanceNodeList : TeaModel {
                /// <summary>
                /// The ID of the host in the dedicated cluster.
                /// </summary>
                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public int? NodeId { get; set; }

                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **db**: data node.
                /// *   **proxy**: proxy node.
                /// *   **normal**: regular node. This value is returned when the instance runs in the standard architecture.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The port number that is used to connect to the node.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   **master**: master node
                /// *   **slave**: replica node
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The zone ID of the node.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The state of the instance. Valid values:
            /// 
            /// *   **Normal**: The instance is normal.
            /// *   **Creating**: The instance is being created.
            /// *   **Changing**: The configurations of the instance are being changed.
            /// *   **Inactive**: The instance is disabled.
            /// *   **Flushing**: The instance is being released.
            /// *   **Released**: The instance is released.
            /// *   **Transforming**: The billing method of the instance is being changed.
            /// *   **Unavailable**: The instance is unavailable.
            /// *   **Error**: The instance failed to be created.
            /// *   **Migrating**: The instance is being migrated.
            /// *   **BackupRecovering**: The instance is being restored from a backup.
            /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
            /// *   **NetworkModifying**: The network type of the instance is being changed.
            /// *   **SSLModifying**: The SSL configurations of the instance are being changed.
            /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The end time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// The start time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// The number of proxy nodes.
            /// 
            /// > 
            /// 
            /// *   If the return value is **0**, the proxy mode is disabled for the instance. If the return value is an integer greater than **0**, such as **1**, the proxy mode is enabled for the instance.
            /// 
            /// *   This parameter is returned only when the instance is a cluster instance. For more information about cluster instances, see [Cluster master-replica instances](https://help.aliyun.com/document_detail/52228.html).
            /// </summary>
            [NameInMap("ProxyCount")]
            [Validation(Required=false)]
            public int? ProxyCount { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of shards.
            /// 
            /// >  This parameter is returned only when the instance is a cluster instance. For more information about cluster instances, see [Cluster master-replica instances](https://help.aliyun.com/document_detail/52228.html).
            /// </summary>
            [NameInMap("ShardCount")]
            [Validation(Required=false)]
            public int? ShardCount { get; set; }

            /// <summary>
            /// The storage type of the instance. The return value is LOCAL_SSD, which indicates [enhanced SSDs (ESSDs)](https://help.aliyun.com/document_detail/122389.html).
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// The VPC ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
