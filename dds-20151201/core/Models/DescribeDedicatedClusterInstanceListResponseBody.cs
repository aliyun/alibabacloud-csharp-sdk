// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDedicatedClusterInstanceListResponseBody : TeaModel {
        /// <summary>
        /// Details about the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeDedicatedClusterInstanceListResponseBodyInstances Instances { get; set; }
        public class DescribeDedicatedClusterInstanceListResponseBodyInstances : TeaModel {
            [NameInMap("dbInstance")]
            [Validation(Required=false)]
            public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstance : TeaModel {
                /// <summary>
                /// The type of the ApsaraDB for MongoDB instance. Valid value: **normal**.
                /// 
                /// **normal**: a replica set instance.
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
                /// The time when the instance was created. The time is displayed in the *yyyy*-*MM*-*dd*T*HH*:*mm*:*ss*Z format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The instance ID of the backend O\&M platform.
                /// </summary>
                [NameInMap("CustomId")]
                [Validation(Required=false)]
                public string CustomId { get; set; }

                /// <summary>
                /// The database engine. Valid value: **MongoDB**.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The version number of the database engine. Valid value: **4.2**.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The instance type. For more information, see **Table 1. Standalone or replica set instance types** in [Instance types](~~57141~~).
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// The ID of the ApsaraDB for MongoDB instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the ApsaraDB for MongoDB instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Details about the instance nodes.
                /// </summary>
                [NameInMap("InstanceNodeList")]
                [Validation(Required=false)]
                public DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeList InstanceNodeList { get; set; }
                public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeList : TeaModel {
                    [NameInMap("InstanceNodes")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeListInstanceNodes> InstanceNodes { get; set; }
                    public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeListInstanceNodes : TeaModel {
                        /// <summary>
                        /// The ID of the host to which the instances in a dedicated cluster belong.
                        /// </summary>
                        [NameInMap("DedicatedHostName")]
                        [Validation(Required=false)]
                        public string DedicatedHostName { get; set; }

                        /// <summary>
                        /// The name of the shard.
                        /// </summary>
                        [NameInMap("InsName")]
                        [Validation(Required=false)]
                        public string InsName { get; set; }

                        /// <summary>
                        /// The ID of the node.
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
                        /// The type of the node.
                        /// </summary>
                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        /// <summary>
                        /// The port number corresponding to the node.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The role of the node. Valid values:
                        /// 
                        /// *   **master**: a primary node.
                        /// *   **slave**: a secondary node.
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// The zone ID of the instance.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// The status of the instance. More details of status, please see [instance status list](~~190071~~).
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// The end time of the maintenance window. The time is in the *HH:mmZ* format. The time is displayed in UTC.
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
                /// The region where the instance is deployed.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The ID of the region where the instance is deployed.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The type of the storage.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The vSwitch ID of the VPC.
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The number of instances in the response.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
