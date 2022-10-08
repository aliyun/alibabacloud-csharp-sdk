// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDedicatedClusterInstanceListResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeDedicatedClusterInstanceListResponseBodyInstances Instances { get; set; }
        public class DescribeDedicatedClusterInstanceListResponseBodyInstances : TeaModel {
            [NameInMap("dbInstance")]
            [Validation(Required=false)]
            public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstance : TeaModel {
                [NameInMap("CharacterType")]
                [Validation(Required=false)]
                public string CharacterType { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CustomId")]
                [Validation(Required=false)]
                public string CustomId { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceNodeList")]
                [Validation(Required=false)]
                public DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeList InstanceNodeList { get; set; }
                public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeList : TeaModel {
                    [NameInMap("InstanceNodes")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeListInstanceNodes> InstanceNodes { get; set; }
                    public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeListInstanceNodes : TeaModel {
                        [NameInMap("DedicatedHostName")]
                        [Validation(Required=false)]
                        public string DedicatedHostName { get; set; }

                        [NameInMap("InsName")]
                        [Validation(Required=false)]
                        public string InsName { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public int? NodeId { get; set; }

                        [NameInMap("NodeIp")]
                        [Validation(Required=false)]
                        public string NodeIp { get; set; }

                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
